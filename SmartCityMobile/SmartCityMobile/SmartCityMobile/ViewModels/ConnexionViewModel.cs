using SmartCityMobile.Data;
using SmartCityMobile.Models;
using SmartCityMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartCityMobile.ViewModels
{
    class ConnexionViewModel : BaseViewModel
    {
        public List<Identifiant> LstIdentifiant { get; set; }
        //les propriétés login et password viennet de la classe identifiant par la liste qui est de type identifiant
        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                SetProperty(ref _login, value);
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value;
                SetProperty(ref _password, value);
            }
        }

        public Command LoginCmd { get; }
        public Identifiant IdentifiantModel { get; set; }

        public ConnexionViewModel(INavigation nav)
        {
            LstIdentifiant = new List<Identifiant>();
            LstIdentifiant = RecupData.LstIdentifiants;
            LoginCmd = new Command(LoginCmdExe);
            IdentifiantModel = new Identifiant();
            Nav = nav;
        }

        public async void LoginCmdExe()
        {
            if (string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.Login))
            {
                await Application.Current.MainPage.DisplayAlert("Login", "Entrer Login et MDP", "Ok");
                return;
            }


            if (RecupData.Connection(Login, Password) == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Login", "Entrer Login et MDP", "Ok");
                return;
            }
            else await Nav.PushAsync(new Games());

        }
    }
}
