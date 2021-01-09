using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
   public interface ISaleService
    {
        Task<string> SaveSale(SaleDto saleDto);
        Task<string> SaveContract(ContractDto contractDto);
        Task<string> SaveTypeContract(ContractTypeDto contractTypeDto);

        Task<string> DeleteSale(int id);

        Task<string> DeleteContract(int id);
        Task<string> DeleteTypeContract(int id);
        Task<List<ContractDto>> GetContracts();
        Task<List<ContractTypeDto>> GetTypesContract();
        Task<List<SaleDto>> GetSales();

    }
}
