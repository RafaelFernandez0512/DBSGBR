using Remsys.Domain.Dtos;
using Remsys.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public class SaleService : BaseService, ISaleService
    {
        public async Task<string> DeleteContract(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblContrato, new object[] { id }));
        }



        public async Task<string> DeleteSale(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblVenta, new object[] { id }));
        }

        public async Task<string> DeleteTypeContract(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTipoContrato, new object[] { id }));
        }

        public async Task<List<ContractDto>> GetContracts()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinTipoContrato));
            List<ContractDto> dtos = new List<ContractDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ContractDto
                {
                    IdAttorney = item.Field<int>(0),
                    Id = item.Field<int>(1),
                    IdContractType = item.Field<int>(2),
                    ContractTypeDto   = new ContractTypeDto
                    {
                        Id = item.Field<int>(2),
                        Name =  item.Field<string>(3),

                    },
                    Description = item.Field<string>(4),
                    AttorneyDto = new AttorneyDto { 
                        IdAttorney  = item.Field<int>(0),
                        Name = item.Field<string>(5),
                        LastName = item.Field<string>(5),
                    },
                    File = item.Field<string>(6),

                });
            }
            return dtos;
        }




        public async Task<List<SaleDto>> GetSales()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarVentas));
            List<SaleDto> dtos = new List<SaleDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new SaleDto
                {
                    IdAppointment = item.Field<int>(0),
                    IdContract = item.Field<int>(1),
                    Id = item.Field<int>(2),
                    IdSaleManager = item.Field<int>(3),

                });
            }
            return dtos;
        }

        public async Task<List<ContractTypeDto>> GetTypesContract()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTiposContratos));
            List<ContractTypeDto> dtos = new List<ContractTypeDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ContractTypeDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),

                });
            }
            return dtos;
        }

        public async Task<string> SaveContract(ContractDto contractDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblContrato, new object[] { contractDto.IdContractType, contractDto.Id, contractDto.Description, contractDto.File }));
        }



        public async Task<string> SaveSale(SaleDto saleDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblVenta, new object[] { saleDto.IdAppointment, saleDto.IdContract, saleDto.IdSaleManager }));
        }

        public async Task<string> SaveTypeContract(ContractTypeDto contractTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblTipoContrato, new object[] { contractTypeDto.Name }));
        }

        public async Task<string> UpdateContract(ContractDto contractDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblContrato, new object[] { contractDto.Id, contractDto.IdContractType, contractDto.Id, contractDto.Description, contractDto.File }));
        }




        public async Task<string> UpdateTypeContract(ContractTypeDto contractTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateInTblTipoContrato, new object[] { contractTypeDto.Id, contractTypeDto.Name }));
        }
    }
}
