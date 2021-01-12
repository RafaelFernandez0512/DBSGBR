using RemsyApp.Services.Apis;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public class PersonService : BaseService, IPersonService
    {
            IApiClient<IPersonServiceApi> _apiClient;
        public PersonService(IApiClient<IPersonServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<Response<List<AttorneyDto>>> GetAttorneyService()
        {
            var response = await RemoteRequestAsync<List<AttorneyDto>>(_apiClient.Client.GetAttorneyService());
            return response;
        }

        public async Task<Response<AttorneyDto>> GetAttorneyService(int id)
        {
            var response = await RemoteRequestAsync<AttorneyDto>(_apiClient.Client.GetAttorneyService(id));
            return response;
        }

        public async Task<Response<List<CustomerDto>>> GetCustomerService()
        {
            var response = await RemoteRequestAsync< List < CustomerDto >> (_apiClient.Client.GetAttorneyService());
            return response;
        }

        public async Task<Response<CustomerDto>> GetCustomerService(int id)
        {
            var response = await RemoteRequestAsync<CustomerDto>(_apiClient.Client.GetAttorneyService(id));
            return response;
        }

        public async Task<Response<List<EstateAgentDto>>> GetEstateAgentService()
        {
            var response = await RemoteRequestAsync<List<EstateAgentDto>>(_apiClient.Client.GetEstateAgentService());
            return response;
        }

        public async Task<Response<EstateAgentDto>> GetEstateAgentService(int id)
        {
            var response = await RemoteRequestAsync<EstateAgentDto>(_apiClient.Client.GetEstateAgentService(id));
            return response;
        }

        public async Task<Response<List<SaleManagerDto>>> GetSaleManagerService()
        {
            var response = await RemoteRequestAsync< List < SaleManagerDto >> (_apiClient.Client.GetSaleManagerService());
            return response;
        }

        public async Task<Response<SaleManagerDto>> GetSaleManagerService(int id)
        {
            var response = await RemoteRequestAsync<SaleManagerDto>(_apiClient.Client.GetAttorneyService(id));
            return response;
        }

        public async Task<Response<PersonDto>> LogInt(string name, string document)
        {
            var response = await RemoteRequestAsync<PersonDto>(_apiClient.Client.LogInt(name, document));
            return response;
        }


        public async Task<Response<string>> SaveCustomer(CustomerDto customerDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveCustomer(customerDto));
            return response;
        }



        public async Task<Response<string>> UpdatePerson(PersonDto personDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.UpdatePerson(personDto));
            return response;
        }
    }
}
