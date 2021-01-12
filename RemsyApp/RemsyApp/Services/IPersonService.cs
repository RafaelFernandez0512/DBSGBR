using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
   public interface IPersonService
    {

        Task<Response<List<CustomerDto>>> GetCustomerService();
        Task<Response<List<SaleManagerDto>>> GetSaleManagerService();
        Task<Response<List<EstateAgentDto>>> GetEstateAgentService();
        Task<Response<List<AttorneyDto>>> GetAttorneyService();
        Task<Response<string>> UpdatePerson(PersonDto personDto );
        Task<Response<PersonDto>> LogInt(string name, string document);
        Task<Response<string>> SaveCustomer(CustomerDto customerDto );

        Task<Response<CustomerDto>> GetCustomerService(int id);

        Task<Response<SaleManagerDto>> GetSaleManagerService(int id);

        Task<Response<EstateAgentDto>> GetEstateAgentService(int id);

        Task<Response<AttorneyDto>> GetAttorneyService(int id);

    }
}
