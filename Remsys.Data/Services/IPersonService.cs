using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
   public interface IPersonService
    {

        Task<List<CustomerDto>> GetCustomerService();
        Task<List<SaleManagerDto>> GetSaleManagerService();
        Task<List<EstateAgentDto>> GetEstateAgentService();
        Task<List<AttorneyDto>> GetAttorneyService();
        Task<string> UpdatePerson(PersonDto personDto );
        Task<PersonDto> LogInt(string name, string document);
        Task<string> SaveCustomer(CustomerDto customerDto );
        Task<string> SaveSaleManager(SaleManagerDto saleManagerDto );
        Task<string> SaveEstateAgent(EstateAgentDto estateAgentDto );
        Task<string> SaveAttorney(AttorneyDto attorneyDto );

        Task DeleteCustomer(int id);
        Task DeleteSaleManager(int id);
        Task DeleteEstateAgent(int id);
        Task DeleteAttorney(int id);
    }
}
