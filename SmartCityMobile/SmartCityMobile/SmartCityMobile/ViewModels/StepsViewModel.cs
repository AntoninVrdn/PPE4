using Plugin.Media;
using Plugin.Media.Abstractions;
using SmartCityMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartCityMobile.ViewModels
{
    public class StepsViewModel : BaseViewModel
    {
        public Command PhotoCmd { get; }
        private async void PhotoCmdExec()
        {

            var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
            {
                DefaultCamera = CameraDevice.Rear,
                Directory = "Xamarin",
                SaveToAlbum = true,
            });

            //if (photo != null)
            //    PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        public Command QuizzCmd { get; }
        private void QuizzCmdExec()
        {
            Nav.PushAsync(new Quizz());
        }

        public StepsViewModel(INavigation nav)
        {
            PhotoCmd = new Command(PhotoCmdExec);
            QuizzCmd = new Command(QuizzCmdExec);
            Nav = nav;
        }
    }
}
