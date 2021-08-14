using SmartCityMobile.Data;
using SmartCityMobile.Models;
using SmartCityMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartCityMobile.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        public List<Jeu> LstJeux { get; set; }

        public Command ShowStep { get;}

        public GameViewModel(INavigation nav)
        {
            LstJeux = new List<Jeu>();
            LstJeux = RecupData.LstJeu;
            ShowStep = new Command(SomeCommand);
            Nav = nav;
        }

        private Jeu _selectedItem;

        public Jeu SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                SetProperty(ref _selectedItem, value);
                if (_selectedItem == null) return;
                ShowStep.Execute(_selectedItem);

                SelectedItem = null;
            }
        }

        public async void SomeCommand()
        {
            await Nav.PushAsync(new Step());
        }

    }
}
