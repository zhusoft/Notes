using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Notes.Data;
namespace Notes
{
    public partial class App : Application
    {
        public static string FolderPath { get; internal set; }

        static NoteDatabase database;
        public static NoteDatabase Database
        {
            get 
            {
                if (database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Notes.db3"));

                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
