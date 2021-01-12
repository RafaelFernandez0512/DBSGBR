using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
   public interface IAppointmentService
    {
        Task<Response<List<AppointmentDto>>> GetAppointments();
        Task<Response<List<StateAppointmentDto>>> GetStateAppointments();
        Task<Response<string>> SaveAppointment(AppointmentDto appointmentDto);
        Task<Response<string>> SaveStateAppointment(StateAppointmentDto stateAppointmentDto );
        Task<Response<string>> UpdateAppointment(AppointmentDto appointmentDto);
        Task<Response<string>> UpdateStateAppointment(StateAppointmentDto stateAppointmentDto);
        Task<Response<string>> DeleteStateAppointment(int id);
        Task<Response<string>> DeleteAppointment(int id );
    }
}
