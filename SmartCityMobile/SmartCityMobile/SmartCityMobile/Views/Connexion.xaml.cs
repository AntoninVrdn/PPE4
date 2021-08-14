using SmartCityMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCityMobile.Missions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connexion : ContentPage
    {
        public Connexion()
        {
            InitializeComponent();

            this.BindingContext = new ConnexionViewModel(Navigation);
        }
    }
}