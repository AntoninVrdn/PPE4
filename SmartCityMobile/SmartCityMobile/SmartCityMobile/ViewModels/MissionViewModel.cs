using SmartCityMobile.Data;
using SmartCityMobile.Models;
using SmartCityMobile.Missions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using SmartCityMobile.Views;

namespace SmartCityMobile.ViewModels
{
    public class MissionViewModel : BaseViewModel
    {
        public List<Mission> LstMissions { get; set; }
        public Command ShowQuizz { get; }
        public int IdJ { get; set; }

        public MissionViewModel(INavigation nav, int IdJoueur)
        {
            IdJ = IdJoueur;
            LstMissions = RecupData.Missions();
            ShowQuizz = new Command(SomeCommand);
            Nav = nav;
        }

        public async void SomeCommand()
        {
            await Nav.PushAsync(new Quizzs(SelectedItem.ID, IdJ));
            //var QuizzPage = new Quizzs(SelectedItem.ID);
            //await Nav.PushAsync(QuizzPage);
            //Navigation.PushAsync(QuizzPage);
        }

        private Mission _selectedItem;

        public Mission SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                SetProperty(ref _selectedItem, value);
                if (_selectedItem == null) return;
                ShowQuizz.Execute(_selectedItem);

                SelectedItem = null;

                //var t = SetProperty(ref _selectedItem, value);
                //if (t)
                //{
                //    ShowQuizz.Execute(_selectedItem);
                //}
            }
        }
    }
}
