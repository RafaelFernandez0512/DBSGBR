using RemsyApp.Services.Apis;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public class AppointmentService : BaseService, IAppointmentService
    {
        IApiClient<IAppointmentServiceApi> _apiClient;
        public AppointmentService(IApiClient<IAppointmentServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Response<string>> DeleteAppointment(int id)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.DeleteAppointment(id));
            return response;
        }

        public async Task<Response<string>> DeleteStateAppointment(int id)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.DeleteStateAppointment(id));
            return response;
        }

        public async Task<Response<List<AppointmentDto>>> GetAppointments()
        {
            var response = await RemoteRequestAsync<List<AppointmentDto>>(_apiClient.Client.GetAppointments());
            return response;
        }

        public async Task<Response<List<StateAppointmentDto>>> GetStateAppointments()
        {
            var response = await RemoteRequestAsync<List<StateAppointmentDto>>(_apiClient.Client.GetStateAppointments());
            return response;
        }

        public async Task<Response<string>> SaveAppointment(AppointmentDto appointmentDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveAppointment(appointmentDto));
            return response;
        }

        public async Task<Response<string>> SaveStateAppointment(StateAppointmentDto stateAppointmentDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveStateAppointment(stateAppointmentDto));
            return response;
        }

        public async Task<Response<string>> UpdateAppointment(AppointmentDto appointmentDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.UpdateAppointment(appointmentDto));
            return response;
        }

        public async   Task<Response<string>> UpdateStateAppointment(StateAppointmentDto stateAppointmentDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.UpdateStateAppointment(stateAppointmentDto));
            return response;
        }
    }
}
