using SmartCityMobile.Data;
using SmartCityMobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SmartCityMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new Connection());
        }

        protected override void OnStart()
        {
            RecupData maRecup = new RecupData();
            maRecup.RecupLesGames();
            maRecup.RecupLesIdentifiants();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
