﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomFlip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartView : ContentPage
    {
        public StartView()
        {
            InitializeComponent();
        }
        bool tmp = false;
        private void Button_Clicked(object sender, EventArgs e)
        {
            test.IsEnableAnimation = tmp;
            tmp = !tmp;
        }
    }
}