using Prism.Navigation;
using RemsyApp.Services;
using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.ViewModels
{
   public class AppointmentPageViewModel : BaseViewModel
    {
        IAppointmentService _appointmentService ;
        public ObservableCollection<CalendarInlineEvent> CalendarInlineEvents { get; set; } = new ObservableCollection<CalendarInlineEvent>();
        public AppointmentPageViewModel(INavigationService navigationService, IAppointmentService appointmentService) : base(navigationService)
        {
            _appointmentService = appointmentService;
     
        }
       async Task LoadData()
        {
            var response = await _appointmentService.GetAppointments();
            if (response.SuccessResult&& response.Result!=null)
            {
                var calendar = from act in response.Result
                               select new CalendarInlineEvent { StartTime = act.ScheduleDto.VisitTime, EndTime = act.ScheduleDto.EndVisitTime, Subject ="Appointments" };
                calendar.ToList().ForEach(e => CalendarInlineEvents.Add(e));
            }
        }
    }
  }
