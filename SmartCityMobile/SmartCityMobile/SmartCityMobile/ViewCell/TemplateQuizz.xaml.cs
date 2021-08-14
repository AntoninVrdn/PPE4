using SmartCityMobile.Data;
using SmartCityMobile.Models;
using SmartCityMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCityMobile.ViewCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TemplateQuizz : Xamarin.Forms.ViewCell
    {
        public int Points { get; set; }
        public List<Goodie> Goodies { get; set; }
        public TemplateQuizz()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var result = RecupData.Reponse(Entry.Text, Id.Text);
            if (result == 1)
            {
                if (Goodies != null)
                {
                    Goodies.Clear();
                }
                
                Points += int.Parse(Score.Text);
                Goodies = RecupData.Goodies(Points);
                var text = "";
                foreach (var item in Goodies)
                {
                    text += item.Name+"\n";
                }

                var equipes = RecupData.Equipes(IdJ.Text);

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var ret = await Application.Current.MainPage.DisplayAlert("RESULTAT", text, "Save", "Non");
                    if (ret)
                    {
                        RecupData.PostGoodie(Goodies, equipes);
                    }
                });

            }
            else
            {
                Application.Current.MainPage.DisplayAlert("RESULTAT", "Vous avez perdu !", "Ok");
            }
        }
    }
}