using Prism.Navigation;
using RemsyApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
   public class AppointmentPageViewModel : BaseViewModel
    {
        IAppointmentService _appointmentService ;
        public AppointmentPageViewModel(INavigationService navigationService, IAppointmentService appointmentService) : base(navigationService)
        {
            _appointmentService = appointmentService;
     
        }
       async Task LoadData()
        {
            var response = await _appointmentService.GetStateAppointments();
            if (response.SuccessResult&& response.Result!=null)
            {

            }
        }
    }
  }
