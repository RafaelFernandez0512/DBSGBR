using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
   public interface IPersonServiceApi
    {
        [Get("/api/Customer")]
        Task<HttpResponseMessage> GetCustomerService();
        [Get("/api/SaleManager")]
        Task<HttpResponseMessage> GetSaleManagerService();
        [Get("/api/EstateAgent")]
        Task<HttpResponseMessage> GetEstateAgentService();
        [Get("/api/Attorney")]
        Task<HttpResponseMessage> GetAttorneyService();

        [Get("/api/Customer/{id}")]
        Task<HttpResponseMessage> GetCustomerService(int id);
        [Get("/api/SaleManager/{id}")]
        Task<HttpResponseMessage> GetSaleManagerService(int id);
        [Get("/api/EstateAgent/{id}")]
        Task<HttpResponseMessage> GetEstateAgentService(int id);
        [Get("/api/Attorney/{id}")]
        Task<HttpResponseMessage> GetAttorneyService(int id);
        [Put("/api/SaleManager")]
        Task<HttpResponseMessage> UpdatePerson([Body]PersonDto personDto );
        [Post("/api/LogIn/{name}/{idDocumento}")]
        Task<HttpResponseMessage> LogInt(string name, string document);
        [Put("/api/SaleManager")]
        Task<HttpResponseMessage> SaveCustomer([Body]CustomerDto customerDto );
    }
}
