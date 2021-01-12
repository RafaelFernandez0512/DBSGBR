using RemsyApp.Services.Apis;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public class AddressService : BaseService,IAddressService
    {
        IApiClient<IAddressServiceApi> _apiClient;
        public AddressService(IApiClient<IAddressServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<Response<List<AddressDto>>> GetAddress()
        {
            var response = await RemoteRequestAsync<List<AddressDto>>(_apiClient.Client.GetAddress());
            return response;
        }

        public async Task<Response<List<CountryDto>>> GetCountry()
        {
            var response = await RemoteRequestAsync<List<CountryDto>>(_apiClient.Client.GetAddress());
            return response;
        }

        public async Task<Response<List<ProvinceDto>>> GetProvince()
        {
            var response = await RemoteRequestAsync<List<ProvinceDto>>(_apiClient.Client.GetAddress());
            return response;
        }
    }
}
