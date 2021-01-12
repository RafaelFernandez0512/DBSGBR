using Prism.Commands;
using Prism.Navigation;
using RemsyApp.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
   public class LoginPageViewModel:BaseViewModel
    {
        IPersonService _personService;
        public PersonDto PersonDto  { get; set; }
        public DelegateCommand LogInCommand { get=>new DelegateCommand(async ()=> await LogInt());  }
        public LoginPageViewModel(INavigationService navigationService, IPersonService personService ) : base(navigationService)
        {
            _personService = personService;



        }
       async Task LogInt()
        {
           var person = await _personService.LogInt(PersonDto.Name, PersonDto.IdentityDocument);
           
            if (person.SuccessResult&& person.Result!=null)
            {
                var user = person.Result;
                var estateAgent = await  _personService.GetEstateAgentService(user.IdPerson);
                if (estateAgent.SuccessResult && estateAgent.Result!=null)
                {
                    await NavigationService.NavigateAsync("");
                }
                else
                {
                    await NavigationService.NavigateAsync("");
                }
            }
         
        }
    }
}
