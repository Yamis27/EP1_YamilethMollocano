﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EP1_YamilethMollocano
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGo_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new Login());

        }
    }
}
