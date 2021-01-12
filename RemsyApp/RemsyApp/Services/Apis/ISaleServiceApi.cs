using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
   public interface ISaleServiceApi
    {
        [Post("/api/Sale")]
        Task<HttpResponseMessage> SaveSale([Body] SaleDto saleDto);
        [Post("/api/Contract")]
        Task<HttpResponseMessage> SaveContract([Body]ContractDto contractDto);
        [Put("/api/Contract")]
        Task<HttpResponseMessage> UpdateContract([Body] ContractDto contractDto);
        [Delete("/api/Sale/{id}")]
        Task<HttpResponseMessage> DeleteSale(int id);
        [Delete("/api/Contract")]
        Task<HttpResponseMessage> DeleteContract(int id);
        [Get("/api/Contract")]
        Task<HttpResponseMessage> GetContracts();
        [Get("/api/Contract/ContractsType")]
        Task<HttpResponseMessage> GetTypesContract();
        [Get("/api/Sale")]
        Task<HttpResponseMessage> GetSales();

    }
}
