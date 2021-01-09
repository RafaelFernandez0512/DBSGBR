using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
   public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetAppointments();
        Task<List<StateAppointmentDto>> GetStateAppointments();
        Task<string> SaveAppointment(AppointmentDto appointmentDto);
        Task<string> SaveStateAppointment(StateAppointmentDto stateAppointmentDto );
        Task<string> DeleteStateAppointment(int id);
        Task<string> DeleteAppointment(int id );
    }
}
