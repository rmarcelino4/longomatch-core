//
//  Copyright (C) 2014 Andoni Morales Alastruey
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

using System.Collections.Generic;
using System.Collections.ObjectModel;
using LongoMatch.Core.Common;
using LongoMatch.Core.Handlers;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Templates;
using LongoMatch.Drawing.CanvasObjects.Teams;
using VAS.Core.Common;
using VAS.Core.Interfaces.Drawing;
using VAS.Core.Store;
using VAS.Core.Store.Drawables;
using VAS.Drawing;

namespace LongoMatch.Drawing.Widgets
{
	public class TeamTagger: SelectionCanvas
	{
	
		public event PlayersSelectionChangedHandler PlayersSelectionChangedEvent;
		public event TeamSelectionChangedHandler TeamSelectionChangedEvent;
		public event PlayersSubstitutionHandler PlayersSubstitutionEvent;
		public event PlayersPropertiesHandler ShowMenuEvent;

		PlayersTaggerObject tagger;

		public TeamTagger (IWidget widget) : base (widget)
		{
			Accuracy = 0;
			tagger = new PlayersTaggerObject {
				SelectionMode = MultiSelectionMode.Single,
			};
			tagger.PlayersSubstitutionEvent += HandlePlayersSubstitutionEvent;
			tagger.PlayersSelectionChangedEvent += HandlePlayersSelectionChangedEvent;
			tagger.TeamSelectionChangedEvent += HandleTeamSelectionChangedEvent;
			BackgroundColor = App.Current.Style.PaletteBackground;
			ShowSubstitutionButtons = true;
			ObjectsCanMove = false;
			AddObject (tagger);
		}

		public TeamTagger () : this (null)
		{
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			tagger.Dispose ();
		}

		public void LoadTeams (LMTeam homeTeam, LMTeam awayTeam, Image background)
		{
			tagger.LoadTeams (homeTeam, awayTeam, background);
			widget?.ReDraw ();
		}

		public void Reload ()
		{
			tagger.Reload ();
			widget?.ReDraw ();
		}

		public LMProject Project {
			set {
				tagger.Project = value;
			}
		}

		public bool Compact {
			set {
				tagger.Compact = value;
			}
		}

		public Time CurrentTime {
			set {
				tagger.CurrentTime = value;
			}
		}

		public bool SubstitutionMode {
			set {
				tagger.SubstitutionMode = value;
			}
		}

		public bool ShowSubstitutionButtons {
			set {
				tagger.ShowSubsitutionButtons = value;
			}
		}

		public bool ShowTeamsButtons {
			set {
				tagger.ShowTeamsButtons = value;
			}
		}

		public new MultiSelectionMode SelectionMode {
			set {
				tagger.SelectionMode = value;
			}
		}

		public ObservableCollection<LMTeam> SelectedTeams {
			get {
				return tagger.SelectedTeams;
			}
		}

		/// <summary>
		/// Gets or sets the color of the background.
		/// </summary>
		public new Color BackgroundColor {
			set {
				tagger.BackgroundColor = value;
			}
		}

		public void ResetSelection ()
		{
			tagger.ResetSelection ();
		}

		public void Select (TeamType team)
		{
			tagger.Select (team);
		}

		public void Select (IList<LMPlayer> players, IList<LMTeam> teams)
		{
			tagger.Select (players, teams);
		}

		public void Select (LMPlayer p)
		{
			tagger.Select (p);
		}

		public void Substitute (LMPlayer p1, LMPlayer p2, LMTeam team)
		{
			tagger.Substitute (p1, p2, team);
		}

		protected override void ShowMenu (Point coords)
		{
			List<LMPlayer> players = tagger.SelectedPlayers;

			if (players.Count == 0) {
				Selection sel = tagger.GetSelection (coords, 0, true);
				if (sel != null) {
					players = new List<LMPlayer> { (sel.Drawable as SportsPlayerObject).Player };
				}
			} else {
				players = tagger.SelectedPlayers;
			}
			
			if (ShowMenuEvent != null) {
				ShowMenuEvent (players);
			}
		}

		protected override void HandleSizeChangedEvent ()
		{
			if (tagger != null) {
				tagger.Width = widget.Width;
				tagger.Height = widget.Height;
			}
			base.HandleSizeChangedEvent ();
		}

		void HandlePlayersSubstitutionEvent (LMTeam team, LMPlayer p1, LMPlayer p2,
		                                     SubstitutionReason reason, Time time)
		{
			widget?.ReDraw ();
			if (PlayersSubstitutionEvent != null) {
				PlayersSubstitutionEvent (team, p1, p2, reason, time);
			}
		}

		void HandlePlayersSelectionChangedEvent (List<LMPlayer> players)
		{
			if (PlayersSelectionChangedEvent != null) {
				PlayersSelectionChangedEvent (players);
			}
		}

		void HandleTeamSelectionChangedEvent (ObservableCollection<LMTeam> teams)
		{
			if (TeamSelectionChangedEvent != null) {
				TeamSelectionChangedEvent (teams);
			}
		}
	}
}

