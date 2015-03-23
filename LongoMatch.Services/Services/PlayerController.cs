﻿//
//  Copyright (C) 2015 Fluendo S.A.
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using LongoMatch.Core.Common;
using LongoMatch.Core.Handlers;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Interfaces.Multimedia;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Playlists;
using Timer = System.Threading.Timer;

namespace LongoMatch.Services
{
	public class PlayerController: IPlayerController
	{
		public event TimeChangedHandler TimeChangedEvent;
		public event StateChangeHandler PlaybackStateChangedEvent;
		public event LoadDrawingsHandler LoadDrawingsEvent;
		public event PlaybackRateChangedHandler PlaybackRateChangedEvent;
		public event VolumeChangedHandler VolumeChangedEvent;
		public event ElementLoadedHandler ElementLoadedEvent;
		public event PARChangedHandler PARChangedEvent;

		const int TIMEOUT_MS = 20;
		const int SCALE_FPS = 25;

		IPlayer player;
		TimelineEvent loadedEvent;
		IPlaylistElement loadedPlaylistElement;
		Playlist loadedPlaylist;

		Time streamLenght, videoTS, imageLoadedTS;
		bool readyToSeek, stillimageLoaded, ready, delayedOpen;
		double rate;
		MediaFile activeFile;
		Seeker seeker;
		Segment loadedSegment;
		object[] pendingSeek;
		Timer timer;
		IntPtr windowHandle;

		struct Segment
		{
			public Time Start;
			public Time Stop;
		}

		#region Constructors

		public PlayerController ()
		{
			seeker = new Seeker ();
			seeker.SeekEvent += HandleSeekEvent;
			loadedSegment.Start = new Time (-1);
			loadedSegment.Stop = new Time (int.MaxValue);
			videoTS = new Time (0);
			imageLoadedTS = new Time (0);
			streamLenght = new Time (0);
			Step = new Time (5000);
			timer = new Timer (HandleTimeout);
			ready = false;
			CreatePlayer ();
		}

		#endregion

		#region Properties

		public bool IgnoreTicks {
			get;
			set;
		}

		public List<int> CamerasVisible {
			get;
			set;
		}

		public object CamerasLayout {
			get;
			set;
		}

		public List<IntPtr> WindowHandles {
			set {
				throw new NotImplementedException ();
			}
		}

		public IntPtr WindowHandle {
			set {
				windowHandle = value;
				player.WindowHandle = value;
			}
			get {
				return windowHandle;
			}
		}

		public double Volume {
			get {
				return player.Volume;
			}
			set {
				player.Volume = value;
			}
		}

		public double Rate {
			set {
				rate = value;
				player.Rate = value;
				Log.Debug ("Rate set to " + value);
			}
			get {
				return rate;
			}
		}

		public Time CurrentTime {
			get {
				return player.CurrentTime;
			}
		}

		public Time StreamLength {
			get {
				return player.StreamLength;
			}
		}

		public Image CurrentMiniatureFrame {
			get {
				return player.GetCurrentFrame (Constants.MAX_THUMBNAIL_SIZE, Constants.MAX_THUMBNAIL_SIZE);
			}
		}

		public Image CurrentFrame {
			get {
				return player.GetCurrentFrame ();
			}
		}

		public bool Playing {
			get;
			set;
		}

		public MediaFileSet FileSet {
			get;
			protected set;
		}

		public bool Opened {
			get {
				return FileSet != null;
			}
		}

		public Time Step {
			get;
			set;
		}

		#endregion

		#region Private Properties

		IPlayer Player {
			get;
			set;
		}

		#endregion

		#region Public methods

		public void Dispose ()
		{
			IgnoreTicks = true;
			timer.Dispose ();
			player.Dispose ();
		}

		public void Ready ()
		{
			Log.Debug ("Player ready");
			if (delayedOpen) {
				Log.Debug ("Openning delayed file set");
				Open (FileSet, true, true);
			}
			ready = true;
			delayedOpen = false;
		}

		public void Open (MediaFileSet fileSet)
		{
			Log.Debug ("Openning file set");
			if (ready) {
				Open (fileSet, true);
			} else {
				Log.Debug ("Player is not ready, delaying ...");
				delayedOpen = true;
			}
			FileSet = fileSet;
		}

		public void Stop ()
		{
			Log.Debug ("Stop");
			Pause ();
		}

		public void Play ()
		{
			Log.Debug ("Play");
			if (StillImageLoaded) {
				ReconfigureTimeout (TIMEOUT_MS);
				EmitPlaybackStateChanged (true);
			} else {
				EmitLoadDrawings (null);
				player.Play ();
			}
			Playing = true;
		}

		public void Pause ()
		{
			Log.Debug ("Pause");
			if (StillImageLoaded) {
				ReconfigureTimeout (0);
				EmitPlaybackStateChanged (false);
			} else {
				player.Pause ();
			}
			Playing = false;
		}

		public void Close ()
		{
			Log.Debug ("Close");
			player.Error -= OnError;
			player.StateChange -= OnStateChanged;
			player.Eos -= OnEndOfStream;
			player.ReadyToSeek -= OnReadyToSeek;
			ReconfigureTimeout (0);
			player.Dispose ();
			FileSet = null;
		}

		public void TogglePlay ()
		{
			Log.Debug ("Toggle playback");
			if (Playing)
				Pause ();
			else
				Play ();
		}

		public bool Seek (Time time, bool accurate, bool synchronous = false, bool throtlled = false)
		{
			if (!StillImageLoaded) {
				EmitLoadDrawings (null);
				if (readyToSeek) {
					if (throtlled) {
						Log.Debug ("Throttled seek");
						seeker.Seek (accurate ? SeekType.Accurate : SeekType.Keyframe, time);
					} else {
						Log.Debug (string.Format ("Seeking to {0} accurate:{1} synchronous:{2} throttled:{3}",
							time, accurate, synchronous, throtlled));
						player.Seek (time, accurate, synchronous);
						OnTick ();
					}
				} else {
					Log.Debug ("Delaying seek until player is ready");
					pendingSeek = new object[3] { time, 1.0f, false };
				}
			}
			return true;
		}

		public bool Seek (Time time, bool accurate, bool synchronous)
		{
			return Seek (time, accurate, synchronous, false);
		}

		public void Seek (double pos)
		{
			Time seekPos, timePos, duration;
			bool accurate;
			bool throthled;

			Log.Debug (string.Format ("Seek relative to {0}", pos));
			if (SegmentLoaded) {
				duration = loadedSegment.Stop - loadedSegment.Start;
				timePos = duration * pos;
				seekPos = loadedSegment.Start + timePos;
				accurate = true;
				throthled = true;
			} else {
				duration = streamLenght;
				seekPos = timePos = streamLenght * pos;
				accurate = false;
				throthled = false;
			}
			Seek (seekPos, accurate, false, throthled);
			EmitTimeChanged (timePos, duration);
		}

		public bool SeekToNextFrame ()
		{
			Log.Debug ("Seek to next frame");
			if (!StillImageLoaded) {
				EmitLoadDrawings (null);
				if (CurrentTime < loadedSegment.Stop) {
					player.SeekToNextFrame ();
					OnTick ();
				}
			}
			return true;
		}

		public bool SeekToPreviousFrame ()
		{
			Log.Debug ("Seek to previous frame");
			if (!StillImageLoaded) {
				EmitLoadDrawings (null);
				if (CurrentTime > loadedSegment.Start) {
					seeker.Seek (SeekType.StepDown);
				}
			}
			return true;
		}

		public void StepForward ()
		{
			Log.Debug ("Step forward");
			if (StillImageLoaded) {
				return;
			}
			EmitLoadDrawings (null);
			DoStep (Step);
		}

		public void StepBackward ()
		{
			Log.Debug ("Step backward");
			if (StillImageLoaded) {
				return;
			}
			EmitLoadDrawings (null);
			DoStep (new Time (-Step.MSeconds));
		}

		public void FramerateUp ()
		{
			if (!StillImageLoaded) {
				float rate;

				EmitLoadDrawings (null);
				rate = (float)Rate;
				if (rate >= 5) {
					return;
				}
				Log.Debug ("Framerate up");
				if (rate < 1) {
					SetRate (rate + (float)1 / SCALE_FPS);
				} else {
					SetRate (rate + 1);
				}
			}
		}

		public void FramerateDown ()
		{

			if (!StillImageLoaded) {
				float rate;

				EmitLoadDrawings (null);
				rate = (float)Rate;
				if (rate <= (float)1 / SCALE_FPS) {
					return;
				}
				Log.Debug ("Framerate down");
				if (rate > 1) {
					SetRate (rate - 1);
				} else {
					SetRate (rate - (float)1 / SCALE_FPS);
				}
			}
		}

		public void Expose ()
		{
			player.Expose ();
		}

		public void LoadPlaylistEvent (Playlist playlist, IPlaylistElement element)
		{
			Log.Debug (string.Format ("Loading playlist element \"{0}\"", element.Description));

			loadedEvent = null;
			loadedPlaylist = playlist;
			loadedPlaylistElement = element;

			if (element is PlaylistPlayElement) {
				PlaylistPlayElement ple = element as PlaylistPlayElement;
				TimelineEvent play = ple.Play;
				LoadSegment (ple.FileSet, play.Start, play.Stop, play.Start, true, ple.Rate);
			} else if (element is PlaylistVideo) {
				LoadVideo (element as PlaylistVideo);
			} else if (element is PlaylistImage) {
				LoadStillImage (element as PlaylistImage);
			} else if (element is PlaylistDrawing) {
				LoadFrameDrawing (element as PlaylistDrawing);
			}
			EmitElementLoaded (element, playlist.HasNext ());
		}

		public void LoadEvent (MediaFileSet fileSet, TimelineEvent evt, Time seekTime, bool playing)
		{
			Log.Debug (string.Format ("Loading event \"{0}\" seek:{1} playing:{2}", evt.Name, seekTime, playing));

			loadedPlaylist = null;
			loadedPlaylistElement = null;
			loadedEvent = evt;
			if (evt.Start != null && evt.Start != null) {
				LoadSegment (fileSet, evt.Start, evt.Stop, seekTime, playing, evt.Rate);
			} else if (evt.EventTime != null) {
				Seek (evt.EventTime, true);
			} else {
				Log.Error ("Event does not have timing info: " + evt);
			}
			EmitElementLoaded (evt, false);
		}

		public void UnloadCurrentEvent ()
		{
			Log.Debug ("Unload current event");
			Reset ();
			EmitEventUnloaded ();
		}

		public void Next ()
		{
			Log.Debug ("Next");
			if (loadedPlaylistElement != null && loadedPlaylist.HasNext ()) {
				Config.EventsBroker.EmitNextPlaylistElement (loadedPlaylist);
			}
		}

		public void Previous ()
		{
			Log.Debug ("Previous");
			if (StillImageLoaded) {
				imageLoadedTS = new Time (0);
				OnTick ();
			} else if (loadedPlaylistElement != null) {
				if (loadedPlaylist.HasPrev ()) {
					Config.EventsBroker.EmitPreviousPlaylistElement (loadedPlaylist);
				}
			} else if (loadedEvent != null) {
				Seek (loadedEvent.Start, true);
			} else {
				Seek (new Time (0), true);
			}
		}

		#endregion

		#region Signals

		void EmitLoadDrawings (FrameDrawing drawing = null)
		{
			if (LoadDrawingsEvent != null) {
				LoadDrawingsEvent (drawing);
			}
		}

		void EmitElementLoaded (object element, bool hasNext)
		{
			if (ElementLoadedEvent != null) {
				ElementLoadedEvent (element, hasNext);
			}
		}

		void EmitEventUnloaded ()
		{
			EmitElementLoaded (null, false);
		}

		void EmitRateChanged (float rate)
		{
			if (PlaybackRateChangedEvent != null) {
				PlaybackRateChangedEvent (rate);
			}
		}

		void EmitVolumeChanged (float volume)
		{
			if (VolumeChangedEvent != null) {
				VolumeChangedEvent (volume);
			}
		}

		void EmitTimeChanged (Time currentTime, Time duration)
		{
			if (TimeChangedEvent != null) {
				TimeChangedEvent (currentTime, duration, !StillImageLoaded);
			}
		}

		void EmitPARChanged (IntPtr windowHandle, float par)
		{
			if (PARChangedEvent != null) {
				PARChangedEvent (windowHandle, par);
			}
		}

		void EmitPlaybackStateChanged (bool playing)
		{
			if (PlaybackStateChangedEvent != null) {
				PlaybackStateChangedEvent (playing);
			}
		}

		#endregion

		#region Private methods

		void Open (MediaFileSet fileSet, bool seek, bool force = false, bool play = false)
		{
			Reset ();
			if (fileSet != this.FileSet || force) {
				readyToSeek = false;
				FileSet = fileSet;
				activeFile = fileSet.First ();
				if (activeFile.VideoHeight != 0) {
					EmitPARChanged (WindowHandle, (float)(activeFile.VideoWidth * activeFile.Par / activeFile.VideoHeight));
				} else {
					EmitPARChanged (WindowHandle, 1);
				}
				try {
					Log.Debug ("Opening new file " + activeFile.FilePath);
					player.Open (fileSet);
				} catch (Exception ex) {
					Log.Exception (ex);
					//We handle this error async
				}
			} else {
				if (seek) {
					Seek (new Time (0), true);
				}
			}
			if (play) {
				player.Play ();
			}
		}

		void Reset ()
		{
			SetRate (1);
			StillImageLoaded = false;
			loadedSegment.Start = new Time (-1);
			loadedSegment.Stop = new Time (int.MaxValue);
			loadedEvent = null;
		}

		void SetRate (float rate)
		{
			Rate = rate;
			EmitRateChanged (rate);
		}

		bool StillImageLoaded {
			set {
				stillimageLoaded = value;
				if (stillimageLoaded) {
					EmitPlaybackStateChanged (true);
					player.Pause ();
					imageLoadedTS = new Time (0);
					ReconfigureTimeout (TIMEOUT_MS);
				}
			}
			get {
				return stillimageLoaded;
			}
		}

		bool SegmentLoaded {
			get {
				return loadedSegment.Start.MSeconds != -1;
			}
		}

		List<FrameDrawing> EventDrawings {
			get {
				if (loadedEvent != null) {
					return loadedEvent.Drawings;
				} else if (loadedPlaylistElement is PlaylistPlayElement) {
					return (loadedPlaylistElement as PlaylistPlayElement).Play.Drawings;
				}
				return null;
			}
		}

		void LoadSegment (MediaFileSet fileSet, Time start, Time stop, Time seekTime,
		                  bool playing, float rate = 1)
		{
			Log.Debug (String.Format ("Update player segment {0} {1} {2}",
				start.ToMSecondsString (),
				stop.ToMSecondsString (), rate));
			if (fileSet != this.FileSet) {
				Open (fileSet, false);
			}
			Pause ();
			loadedSegment.Start = start;
			loadedSegment.Stop = stop;
			rate = rate == 0 ? 1 : rate;
			StillImageLoaded = false;
			if (readyToSeek) {
				Log.Debug ("Player is ready to seek, seeking to " +
				seekTime.ToMSecondsString ());
				SetRate (rate);
				Seek (seekTime, true);
				if (playing) {
					Play ();
				}
			} else {
				Log.Debug ("Delaying seek until player is ready");
				pendingSeek = new object[3] { seekTime, rate, playing };
			}
		}

		void LoadStillImage (PlaylistImage image)
		{
			loadedPlaylistElement = image;
			StillImageLoaded = true;
		}

		void LoadFrameDrawing (PlaylistDrawing drawing)
		{
			loadedPlaylistElement = drawing;
			StillImageLoaded = true;
		}

		void LoadVideo (PlaylistVideo video)
		{
			loadedPlaylistElement = video;
			MediaFileSet fileSet = new MediaFileSet ();
			fileSet.Add (video.File);
			Open (fileSet, false, true, true);
		}

		void LoadPlayDrawing (FrameDrawing drawing)
		{
			Pause ();
			IgnoreTicks = true;
			player.Seek (drawing.Render, true, true);
			IgnoreTicks = false;
			EmitLoadDrawings (drawing);
		}

		void DoStep (Time step)
		{
			Time pos = CurrentTime + step;
			if (pos.MSeconds < 0)
				pos.MSeconds = 0;
			Log.Debug (String.Format ("Stepping {0} seconds from {1} to {2}",
				step, CurrentTime, pos));
			EmitLoadDrawings (null);
			Seek (pos, true);
		}

		void CreatePlayer ()
		{
			player = Config.MultimediaToolkit.GetPlayer ();

			player.Error += OnError;
			player.StateChange += OnStateChanged;
			player.Eos += OnEndOfStream;
			player.ReadyToSeek += OnReadyToSeek;
		}

		void ReconfigureTimeout (uint mseconds)
		{
			if (mseconds == 0) {
				timer.Change (Timeout.Infinite, Timeout.Infinite);
			} else {
				timer.Change (mseconds, mseconds);
			}
		}

		void DoStateChanged (bool playing)
		{
			if (playing) {
				ReconfigureTimeout (TIMEOUT_MS);
			} else {
				if (!StillImageLoaded) {
					ReconfigureTimeout (0);
				}
			}
			EmitPlaybackStateChanged (playing);
		}

		void DoReadyToSeek ()
		{
			readyToSeek = true;
			streamLenght = player.StreamLength;
			if (pendingSeek != null) {
				SetRate ((float)pendingSeek [1]);
				player.Seek ((Time)pendingSeek [0], true);
				if ((bool)pendingSeek [2]) {
					Play ();
				}
				pendingSeek = null;
			}
			OnTick ();
			player.Expose ();
		}

		#endregion

		#region Backend Callbacks

		/* These callbacks are triggered by the multimedia backend and need to
		 * be deferred to the UI main thread */
		void OnStateChanged (bool playing)
		{
			Config.DrawingToolkit.Invoke (delegate {
				DoStateChanged (playing);
			});
		}

		void OnReadyToSeek ()
		{
			Config.DrawingToolkit.Invoke (delegate {
				DoReadyToSeek ();
			});
		}

		void OnEndOfStream ()
		{
			Config.DrawingToolkit.Invoke (delegate {
				if (loadedPlaylistElement is PlaylistVideo) {
					Config.EventsBroker.EmitNextPlaylistElement (loadedPlaylist);
				} else {
					Seek (new Time (0), true);
					Pause ();
				}
			});
		}

		void OnError (string message)
		{
			Config.DrawingToolkit.Invoke (delegate {
				Config.EventsBroker.EmitMultimediaError (message);
			});
		}

		#endregion

		#region Callbacks

		void HandleTimeout (Object state)
		{
			Config.DrawingToolkit.Invoke (delegate {
				OnTick ();
			});
		}

		bool OnTick ()
		{
			if (IgnoreTicks) {
				return true;
			}

			if (StillImageLoaded) {
				EmitTimeChanged (imageLoadedTS, loadedPlaylistElement.Duration);
				if (imageLoadedTS >= loadedPlaylistElement.Duration) {
					Config.EventsBroker.EmitNextPlaylistElement (loadedPlaylist);
				} else {
					imageLoadedTS.MSeconds += TIMEOUT_MS;
				}
				return true;
			} else {
				Time currentTime = CurrentTime;

				if (SegmentLoaded) {
					EmitTimeChanged (currentTime - loadedSegment.Start,
						loadedSegment.Stop - loadedSegment.Start);
					if (currentTime > loadedSegment.Stop) {
						/* Check if the segment is now finished and jump to next one */
						Pause ();
						Config.EventsBroker.EmitNextPlaylistElement (loadedPlaylist);
					} else {
						var drawings = EventDrawings;
						if (drawings != null) {
							/* Check if the event has drawings to display */
							FrameDrawing fd = drawings.FirstOrDefault (f => f.Render > videoTS && f.Render <= currentTime);
							if (fd != null) {
								LoadPlayDrawing (fd);
							}
						}
					}
				} else {
					EmitTimeChanged (currentTime, streamLenght);
				}
				videoTS = currentTime;

				Config.EventsBroker.EmitPlayerTick (currentTime);
				return true;
			}
		}

		void HandleSeekEvent (SeekType type, Time start, float rate)
		{
			Config.DrawingToolkit.Invoke (delegate {
				EmitLoadDrawings (null);
				/* We only use it for backwards framestepping for now */
				if (type == SeekType.StepDown || type == SeekType.StepUp) {
					if (player.Playing)
						Pause ();
					if (type == SeekType.StepDown)
						player.SeekToPreviousFrame ();
					else
						player.SeekToNextFrame ();
					OnTick ();
				}
				if (type == SeekType.Accurate || type == SeekType.Keyframe) {
					SetRate (rate);
					Seek (start, type == SeekType.Accurate, false, false);
				}
			});
		}

		#endregion
	}
}

