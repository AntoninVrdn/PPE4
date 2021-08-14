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
    public class ReponseViewModel : BaseViewModel
    {
        public List<Reponse> LstReponses { get; set; }
        public Command ShowReponse { get; set; }


    }
}
