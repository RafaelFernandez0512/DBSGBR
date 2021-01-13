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
   public class HomePageViewModel : BaseViewModel
    {
        IPropertyService _propertyService;
        IPersonService _personService;
        public ObservableCollection<PropertyDto> Propertys { get; set; }
        public ObservableCollection<EstateAgentDto> Agents { get; set; }

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

        public DelegateCommand GoToDetailCommand
        {
            get => new DelegateCommand(() => {

                NavigationService.NavigateAsync(new Uri($"/{NavigationUri.DetailPropertyPage}", UriKind.Relative), new NavigationParameters() { { nameof(PropertyDto), Selectproperty } });
            });
        }
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
                    Propertys = new ObservableCollection<PropertyDto>(propertys.Result.Where(e => e.Rate >= 4));
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
