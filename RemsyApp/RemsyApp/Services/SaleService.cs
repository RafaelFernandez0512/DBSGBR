using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
   public class SaleService:BaseService,ISaleService
    {
        IApiClient<ISaleServiceApi> _apiClient;

        public SaleService(IApiClient<ISaleServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<Response<string>> DeleteContract(int id)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.DeleteContract(id));
            return response;
        }

        public async Task<Response<string>> DeleteSale(int id)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.DeleteSale(id));
            return response;
        }

        public async Task<Response<List<ContractDto>>> GetContracts()
        {
            var response = await RemoteRequestAsync<List<ContractDto>>(_apiClient.Client.GetContracts());
            return response;
        }

        public async Task<Response<List<SaleDto>>> GetSales()
        {
            var response = await RemoteRequestAsync<List<SaleDto>>(_apiClient.Client.GetSales());
            return response;
        }

        public async Task<Response<List<ContractTypeDto>>> GetTypesContract()
        {
            var response = await RemoteRequestAsync<List<ContractTypeDto>>(_apiClient.Client.GetTypesContract());
            return response;
        }

        public async Task<Response<string>> SaveContract(ContractDto contractDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveContract(contractDto));
            return response;
        }

        public async Task<Response<string>> SaveSale(SaleDto saleDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.SaveSale(saleDto));
            return response;
        }

        public async Task<Response<string>> UpdateContract(ContractDto contractDto)
        {
            var response = await RemoteRequestAsync<string>(_apiClient.Client.UpdateContract(contractDto));
            return response;
        }
    }
}
