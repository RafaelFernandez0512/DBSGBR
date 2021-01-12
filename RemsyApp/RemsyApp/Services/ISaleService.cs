using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
   public interface ISaleService
    {
        Task<Response<string>> SaveSale(SaleDto saleDto);
        Task<Response<string>> SaveContract(ContractDto contractDto);
        Task<Response<string>> UpdateContract(ContractDto contractDto);

        Task<Response<string>> DeleteSale(int id);

        Task<Response<string>> DeleteContract(int id);
        Task<Response<List<ContractDto>>> GetContracts();
        Task<Response<List<ContractTypeDto>>> GetTypesContract();
        Task<Response<List<SaleDto>>> GetSales();

    }
}
