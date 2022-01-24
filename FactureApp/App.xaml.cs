using FactureApp.DAO;
using FactureApp.View;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FactureApp
{
    public partial class App : Application
    {
        private static Database database;
       
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "factures.db"));
                    
                }
                return database;
            }
           
        }     
                public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage (new Facturation());
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
