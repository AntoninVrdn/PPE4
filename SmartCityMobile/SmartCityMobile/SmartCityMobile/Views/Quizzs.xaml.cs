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
    public partial class Quizzs : ContentPage
    {
        public Quizzs(int ID, int IdJ)
        {
            InitializeComponent();
            this.BindingContext = new QuestionViewModel(Navigation, ID, IdJ); 
        }
    }
}