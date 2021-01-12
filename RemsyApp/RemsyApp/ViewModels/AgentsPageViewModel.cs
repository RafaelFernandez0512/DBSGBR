using Prism.Navigation;
using RemsyApp.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
    public class AgentsPageViewModel:BaseViewModel
    {
        IPersonService _personService ;
    public ObservableCollection<EstateAgentDto> EstateAgents  { get; set; }
    public AgentsPageViewModel(INavigationService navigationService, IPersonService personService) : base(navigationService)
    {
            _personService = personService;
        Task.Run(async () => await GetAgents());
    }
    async Task GetAgents()
    {
        var estateAgents = await _personService.GetEstateAgentService();
        if (estateAgents.SuccessResult)
        {
            if (estateAgents.Result != null)
                    EstateAgents = new ObservableCollection<EstateAgentDto>(estateAgents.Result);
        }
    }
}
}
