using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RemsyApp.ViewModels
{
    public class BaseViewModel:INotifyPropertyChanged
    {
        protected INavigationService NavigationService;
        public bool IsBusy { get; set; }
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
