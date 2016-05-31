﻿//
//  Copyright (C) 2015 Andoni Morales Alastruey
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
using Couchbase.Lite;
using LongoMatch.Core.Store;
using LongoMatch.Core.Store.Templates;
using VAS.Core.Store;
using VAS.DB;
using LongoMatch.DB.Views;
using VAS.Core.Store.Playlists;

namespace LongoMatch.DB
{
	public class CouchbaseStorageLongoMatch: CouchbaseStorage
	{
		static CouchbaseStorageLongoMatch ()
		{
		}

		public CouchbaseStorageLongoMatch (Database db) : base (db)
		{
		}

		public CouchbaseStorageLongoMatch (Manager manager, string storageName) : base (manager, storageName)
		{
		}

		public CouchbaseStorageLongoMatch (string dbDir, string storageName) : base (dbDir, storageName)
		{
		}


		protected override void InitializeViews ()
		{
			AddView (typeof(EventType), new EventTypeView (this));
			AddView (typeof(TimelineEventLongoMatch), new TimelineEventsView (this));
			AddView (typeof(ProjectLongoMatch), new ProjectsView (this));
			AddView (typeof(SportsTeam), new TeamsView (this));
			AddView (typeof(DashboardLongoMatch), new DashboardsView (this));
			AddView (typeof(PlayerLongoMatch), new PlayersView (this));
		}

		protected override void InitializeDocumentTypeMappings ()
		{
			base.InitializeDocumentTypeMappings ();
			DocumentsSerializer.DocumentTypeBaseTypes.Add (typeof(Playlist), "Playlist");
			DocumentsSerializer.DocumentTypeBaseTypes.Add (typeof(MediaFileSet), "MediaFileSet");
		}
	}
}

