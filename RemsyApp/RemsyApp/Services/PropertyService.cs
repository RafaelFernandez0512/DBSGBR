using RemsyApp.Services.Apis;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public class PropertyService : BaseService, IPropertyService
    {
        IApiClient<IPropertyServiceApi> _apiClient;
        public PropertyService(IApiClient<IPropertyServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<Response<List<PropertyDto>>> GetProperty()
        {
            var response = await RemoteRequestAsync<List<PropertyDto>>(_apiClient.Client.GetProperty());
            return response;
        }

        public async Task<Response<List<PropertyDto>>> GetProperty(string id)
        {
            var response = await RemoteRequestAsync<List<PropertyDto>>(_apiClient.Client.GetProperty(id));
            return response;
        }

        public async Task<Response<List<ProperyOperationTypeDto>>> GetTypeOperation()
        {
            var response = await RemoteRequestAsync<List<ProperyOperationTypeDto>>(_apiClient.Client.GetTypeOperation());
            return response;
        }

        public async Task<Response<List<PropertyTypeDto>>> GetTypeProperty()
        {
            var response = await RemoteRequestAsync<List<PropertyTypeDto>>(_apiClient.Client.GetTypeProperty());
            return response;
        }

        public async Task<Response<List<TypeRoomDto>>> GetTypeRoom()
        {
            var response = await RemoteRequestAsync<List<TypeRoomDto>>(_apiClient.Client.GetTypeRoom());
            return response;
        }

        public async Task<Response<string>> SaveProperty(PropertyDto propertyDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveProperty(propertyDto));
            return response;
        }

    }
}
