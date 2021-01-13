using Prism.Commands;
using Prism.Navigation;
using RemsyApp.Helpers;
using RemsyApp.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
    public  class DepartmentPageViewModel: BaseViewModel
    {
        IPropertyService _propertyService;
        public ObservableCollection<PropertyDto> Propertys  { get; set; }
        private PropertyDto selectproperty;

        public PropertyDto Selectproperty
        {
            get { return selectproperty; }
            set
            {
                selectproperty = value;
                if (selectproperty != null)
                {
                    GoToDetailCommand.Execute();
                    selectproperty = null;
                }
            }
        }
        public DelegateCommand GoToDetailCommand { get => new DelegateCommand(()=> {

            NavigationService.NavigateAsync(new Uri($"/{NavigationUri.DetailPropertyPage}",UriKind.Relative), new NavigationParameters() { { nameof(PropertyTypeDto), Selectproperty } });
        }); }

        public DepartmentPageViewModel(INavigationService navigationService, IPropertyService propertyService) :base(navigationService)
        {
            _propertyService = propertyService;
            Task.Run(async () => await GetDepartaments());
        }
       async Task GetDepartaments()
        {
            IsBusy = true;
            var propertys = await _propertyService.GetProperty();
            if (propertys.SuccessResult)
            {
                if(propertys.Result!=null)
                Propertys = new ObservableCollection<PropertyDto>(propertys.Result.Where(e=>e.IdPropertyType==1));
            }
            IsBusy = false;
        }
    }
}
