using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
   public interface IAppointmentServiceApi
    {
        [Get("/api/Appointment")]
        Task<HttpResponseMessage> GetAppointments();
        [Get("/api/StateAppointment")]
        Task<HttpResponseMessage> GetStateAppointments();
        [Post("/api/Appointment")]
        Task<HttpResponseMessage> SaveAppointment([Body]AppointmentDto appointmentDto);
        [Post("/api/StateAppointment")]
        Task<HttpResponseMessage> SaveStateAppointment([Body] StateAppointmentDto stateAppointmentDto );
        [Put("/api/StateAppointment")]
        Task<HttpResponseMessage> UpdateAppointment([Body] AppointmentDto appointmentDto);
        [Put("/api/StateAppointment")]
        Task<HttpResponseMessage> UpdateStateAppointment([Body] StateAppointmentDto stateAppointmentDto);
        [Delete("/api/Appointment/{id}")]
        Task<HttpResponseMessage> DeleteStateAppointment(int id);
        [Delete("/api/StateAppointment/{id}")]
        Task<HttpResponseMessage> DeleteAppointment(int id );
    }
}
