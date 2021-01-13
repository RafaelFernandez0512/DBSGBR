using Prism.Navigation;
using RemsyApp.Models;
using RemsyApp.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
    public class ProfilePageViewModel:BaseViewModel
    {
        IPersonService _personService;
        IPropertyService _propertyService;
        public ObservableCollection<PropertyDto> AssignedProperty { get; set; }
        public EstateAgentDto EstateAgentDto  { get; set; }
        public ProfilePageViewModel(INavigationService navigationService,IPersonService personService,IPropertyService propertyService ):base(navigationService)
        {
            _personService = personService;
            _propertyService = propertyService;
            Task.Run(() => LoadData(Settings.IdPerson));
        }
       async Task LoadData(int id)
        {
            var person = await _personService.GetEstateAgentService(id);
            if (person.SuccessResult&&person.Result!=null)
            {
                EstateAgentDto = person.Result;
                var properties = await  _propertyService.GetProperty($"{id}");
                if (properties.SuccessResult&& properties.Result!=null)
                {
                    AssignedProperty = new ObservableCollection<PropertyDto>(properties.Result);
                }
            }
        }
    }
}
