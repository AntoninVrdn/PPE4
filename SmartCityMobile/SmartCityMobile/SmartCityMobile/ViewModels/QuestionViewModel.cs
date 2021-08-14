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
using Newtonsoft.Json;

namespace SmartCityMobile.ViewModels
{
    public class QuestionViewModel : BaseViewModel
    {
        public List<Question> LstQuestions { get; set; }
        public List<Goodie> LstGoodies { get; set; }
        public int IdJoueur { get; set; }

        private int _points;

        public  int Points
        {
            get { return _points; }
            set
            {
                _points = value;
                SetProperty(ref _points, value);
            }
        }

        public QuestionViewModel(INavigation nav, int ID, int IdJ) 
        {
            IdJoueur = IdJ;
            LstQuestions = RecupData.Questions(ID);

            LstGoodies = RecupData.GoodiesEquipe(RecupData.Equipes(IdJ.ToString())); 

            foreach (var question in LstQuestions)
            {
                question.IdJ = IdJoueur;
            }
            Nav = nav;
        }

        public QuestionViewModel()
        {

        }

        public void AddPoints(int points)
        {
            Points += points;
        }
    }
}
