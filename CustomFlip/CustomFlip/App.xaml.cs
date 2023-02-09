using CustomFlip.ViewModels;
using CustomFlip.Views;
using Prism;
using Prism.Ioc;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomFlip
{
    public partial class App
    {
        //public App() :this(null)
        //{

        //    //MainPage = new MainPage();
        //}
        public App(IPlatformInitializer platformInitializer) 
            : base(platformInitializer) 
        { 
        
        }
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{nameof(StartView)}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<StartView, StartViewModel>(); 
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
