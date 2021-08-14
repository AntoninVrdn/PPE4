using SmartCityMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCityMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step : ContentPage
    {
        public Step()
        {
            InitializeComponent();
            this.BindingContext = new StepsViewModel(Navigation);
        }

        public void ShowEtape()
        {

        }

        public void QuizzClicked()
        {

        }

        public void PhotoClicked()
        {

        }

        public void ScoresClicked()
        {

        }
    }
}