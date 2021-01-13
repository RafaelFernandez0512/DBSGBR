using Prism.Navigation;
using RemsyApp.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemsyApp.ViewModels
{
    public class DetailPropertyPageViewModel:BaseViewModel,IInitialize
    {
        public PropertyDto Property  { get; set; }
        public DetailPropertyPageViewModel(INavigationService navigationService, IPropertyService propertyService) : base(navigationService)
        {

        }

        public void Initialize(INavigationParameters parameters)
        {
            Property = parameters[nameof(PropertyDto)] as PropertyDto;
        }
    }
}
