using Prism.Navigation;
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
    public class HousesPageViewModel : BaseViewModel
    {
        IPropertyService _propertyService;
        public ObservableCollection<PropertyDto> Propertys { get; set; }
        public HousesPageViewModel(INavigationService navigationService, IPropertyService propertyService) : base(navigationService)
        {
            _propertyService = propertyService;
            Task.Run(async () => await GetHouses());
        }
        async Task GetHouses()
        {
            var propertys = await _propertyService.GetProperty();
            if (propertys.SuccessResult)
            {
                if (propertys.Result != null)
                    Propertys = new ObservableCollection<PropertyDto>(propertys.Result.Where(e => e.IdPropertyType == 3));
            }
        }
    }
}
