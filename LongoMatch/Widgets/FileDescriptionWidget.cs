// FileDescriptionWidget.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using Mono.Unix;
using Gtk;
using LongoMatch.DB;
using LongoMatch.Handlers;
using LongoMatch.IO;
using LongoMatch.Widgets.Popup;
using LongoMatch.Widgets.Dialog;
using LongoMatch.TimeNodes;

namespace LongoMatch.Widgets.Component
{

	//añadir eventos de cambios para realizar el cambio directamente sobre el file data abierto
	public partial class FileDescriptionWidget : Gtk.Bin
	{

		private DateTime date;
		private Project project;
		private MediaFile mFile;
		private CalendarPopup cp;
		
		
		public FileDescriptionWidget()
		{
			this.Build();
			cp = new CalendarPopup();			
			cp.Hide();
			cp.DateSelectedEvent += new DateSelectedHandler(OnDateSelected);
			date = System.DateTime.Today;
			dateEntry.Text = date.ToString(Catalog.GetString("MM/dd/yyyy"));
			string[] allFiles = System.IO.Directory.GetFiles(MainClass.TemplatesDir(),"*.sct");
			foreach (string filePath in allFiles){
				combobox1.AppendText(System.IO.Path.GetFileNameWithoutExtension(filePath));
			}
			combobox1.Active=0;
			
		}
		
		public string LocalName {
			get { return localTeamEntry.Text; }
			set { this.localTeamEntry.Text = value;}
		}
		
		public string VisitorName{
			get { return visitorTeamEntry.Text; }
			set { this.visitorTeamEntry.Text = value;}
		}
		
		public int LocalGoals{
			get { return (int)localSpinButton.Value; }
			set { this.localSpinButton.Value = value;}
		}
		
		public int VisitorGoals{
			get { return (int)visitorSpinButton.Value; }
			set { this.visitorSpinButton.Value = value;}
		}
		
		private string Filename {
			get { return fileEntry.Text;}
			set { this.fileEntry.Text = value;}
		}
		
		public DateTime Date{
			get {return date;}
			set { this.dateEntry.Text = value.ToString(Catalog.GetString("MM/dd/yyyy"));}
		}
		
		
		
		private string SectionsFile{
			get {
				string filename =  combobox1.ActiveText + ".sct";
				return filename;
				}
		}
		

		public void SetProject(Project project){
			this.project = project;
			this.mFile = project.File;
			this.Filename = this.mFile.FilePath;
			this.LocalName = project.LocalName;
			this.VisitorName = project.VisitorName;
			this.LocalGoals = project.LocalGoals;
			this.VisitorGoals = project.VisitorGoals;
			this.Date= project.MatchDate;

			
			//Cambiamos el gui

			this.combobox1.Visible = false;
			this.editbutton.Sensitive = true;
			
		}
		
		public void UpdateProject(){
			project.File=this.mFile;
			project.LocalName = this.localTeamEntry.Text;
			project.VisitorName = this.visitorTeamEntry.Text;
			project.LocalGoals = (int)this.localSpinButton.Value;
			project.VisitorGoals = (int)this.visitorSpinButton.Value;
			project.MatchDate = DateTime.Parse(this.dateEntry.Text);

		
		}
		
	
		
		public Project GetProject(){
			if (this.Filename != ""){
				SectionsReader reader = new SectionsReader(System.IO.Path.Combine(MainClass.TemplatesDir(),this.SectionsFile));
				Sections sections = reader.GetSections();

				
				if (project == null){
					return new Project(this.mFile,
					                    this.LocalName,
					                    this.VisitorName,
					                    this.LocalGoals,
					                    this.VisitorGoals,
					                    this.Date,
					                    sections);
				}
				else {
					project.File = this.mFile;
					project.LocalName = this.LocalName;
					project.VisitorGoals = this.VisitorGoals;
					project.LocalGoals = this.LocalGoals;
					project.VisitorGoals = this.VisitorGoals;
					project.MatchDate = this.Date;

					return project;
					 
						
				}
				
			}
			else return null;
		}
		
		public void Clear(){
			
			this.LocalName = "";
			this.VisitorName = "";
			this.LocalGoals = 0;
			this.VisitorGoals = 0;
			this.Date = System.DateTime.Today;
			this.Filename = "";
			this.mFile = null;

			
		}

		protected virtual void OnDateSelected(DateTime dateTime){
			this.dateEntry.Text = dateTime.ToString(Catalog.GetString("MM/dd/yyyy"));
		}
		
		protected virtual void OnOpenbuttonClicked(object sender, System.EventArgs e)
		{
			
			FileChooserDialog fChooser = new FileChooserDialog(Catalog.GetString("Choose the file to open"),
			                                                   null,
			                                                   FileChooserAction.Open,
			                                                   "gtk-cancel",ResponseType.Cancel,
			                                                   "gtk-open",ResponseType.Accept);
			
			
			fChooser.SetCurrentFolder(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			if (fChooser.Run() == (int)ResponseType.Accept){
				LongoMatch.Video.Player.PlayerMaker pm = new LongoMatch.Video.Player.PlayerMaker();
				LongoMatch.Video.Player.IMetadataReader reader = pm.getMetadataReader();
					try{
						reader.Open(fChooser.Filename);
						int duration = (int)reader.GetMetadata(LongoMatch.Video.Player.GstPlayerMetadataType.Duration);
						int fps = (int) reader.GetMetadata(LongoMatch.Video.Player.GstPlayerMetadataType.Fps);
						bool hasVideo = (bool) reader.GetMetadata(LongoMatch.Video.Player.GstPlayerMetadataType.HasVideo);
						bool hasAudio = (bool) reader.GetMetadata(LongoMatch.Video.Player.GstPlayerMetadataType.HasAudio);
						
						this.mFile = new MediaFile(fChooser.Filename,new Time(duration*1000),(ushort)fps,hasAudio,hasVideo);				
						fileEntry.Text = fChooser.Filename;
			
					}
					catch (GLib.GException ex){
						MessageDialog errorDialog = new MessageDialog(null,DialogFlags.Modal,MessageType.Error,ButtonsType.Ok,
						                                              Catalog.GetString("Error Loading this file:\n")+ex.Message);
						errorDialog.Run();
						errorDialog.Destroy();
					}
				
			}
		
			fChooser.Destroy();
		}
	







		protected virtual void OnCalendarbuttonClicked (object sender, System.EventArgs e)
		{
			cp.Show();
		}

		protected virtual void OnEditbuttonClicked (object sender, System.EventArgs e)
		{
			
			TemplateEditorDialog ted = new TemplateEditorDialog();
			ted.Sections=project.Sections;
			
			if (ted.Run() == (int)ResponseType.Apply){
				project.Sections = ted.Sections;
			}
			
			ted.Destroy();
		}
		
		
	}
}
