using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomFlip.ViewModels
{
    internal class StartViewModel :ViewModelBase
    {
        public StartViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = "Start page";
        }
    }
}
