using Prism.Commands;
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
   public class HomePageViewModel : BaseViewModel
    {
        IPropertyService _propertyService;
        IPersonService _personService;
        public ObservableCollection<PropertyDto> Propertys { get; set; }
        public ObservableCollection<EstateAgentDto> Agents { get; set; }

     
        public HomePageViewModel(INavigationService navigationService, IPropertyService propertyService,IPersonService personService) : base(navigationService)
        {
            _propertyService = propertyService;
            _personService = personService;
           
            
            Task.Run(async () => await GetDepartaments());
        }
        async Task GetDepartaments()
        {
            var propertys = await _propertyService.GetProperty();
            if (propertys.SuccessResult)
            {
                if (propertys.Result != null)
                    Propertys = new ObservableCollection<PropertyDto>(propertys.Result.Where(e => e.IdPropertyType == 2));
            }
        }
        async Task GetPerson()
        {
            var agents = await _personService.GetEstateAgentService();
            if (agents.SuccessResult)
            {
                if (agents.Result != null)
                    Agents = new ObservableCollection<EstateAgentDto>(agents.Result);
            }
        }
    }
}
