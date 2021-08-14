﻿using SmartCityMobile.ViewModels;
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
    public partial class Games : ContentPage
    {
        public Games()
        {
            InitializeComponent();
            this.BindingContext = new GameViewModel(Navigation);
        }
    }
}