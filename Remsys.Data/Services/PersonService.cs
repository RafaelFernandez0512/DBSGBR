using Remsys.Domain.Dtos;
using Remsys.Data.Helpers;
using Remsys.Data.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public class PersonService : BaseService, IPersonService
    {
        public async Task DeleteAttorney(int id)
        {
            object[] person = new object[] { id };
             await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblAbogado, person));
        }

        public async Task DeleteCustomer(int id)
        {
            object[] person = new object[] { id };
            await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblCliente, person));
        }

        public async Task DeleteEstateAgent(int id)
        {
            object[] person = new object[] { id };
            await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblAgenteInmobilario, person));
        }

        public async Task DeleteSaleManager(int id)
        {
            object[] person = new object[] { id };
            await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblEncargadoDeVenta, person));
        }

        public async Task<List<AttorneyDto>> GetAttorneyService()
        {
         var datas =  await Task.FromResult(Getdata(StoreProcedureConstant.JoinAbogadoPersona));
            List<AttorneyDto> dtos  = new List<AttorneyDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new AttorneyDto
                {
                    IdAttorney = item.Field<int>(0),
                    IdPerson = item.Field<int>(1),
                    IdDocumentType = item.Field<int>(2),
                    DocumentType = new DocumentTypeDto { 
                    Id= item.Field<int>(2),
                    Name= item.Field<string>(3),
                    },
                    Name = item.Field<string>(4),
                    LastName = item.Field<string>(5),
                    DateBorn = item.Field<DateTime>(6),
                    Mail = item.Field<string>(7),
                    DateCreate = item.Field<DateTime>(8),
                    Phone = item.Field<string>(9),
                });
            }
            return dtos;
        }

        public async Task<List<CustomerDto>> GetCustomerService()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinClientePersona));
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                customerDtos.Add(new CustomerDto
                {
                    IdCustomer = item.Field<int>(0),
                    IdPerson = item.Field<int>(1),
                    IdDocumentType = item.Field<int>(2),
                    DocumentType = new DocumentTypeDto
                    {
                        Id = item.Field<int>(2),
                        Name = item.Field<string>(3),
                    },
                    Name = item.Field<string>(4),
                    LastName = item.Field<string>(5),
                    DateBorn = item.Field<DateTime>(6),
                    Mail = item.Field<string>(7),
                    DateCreate = item.Field<DateTime>(8),
                    Phone = item.Field<string>(9),

                });
            }
            return customerDtos;
        }

        public async Task<List<EstateAgentDto>> GetEstateAgentService()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinAgenteInmboliarioPersona));
            List<EstateAgentDto> estateAgents  = new List<EstateAgentDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                estateAgents.Add(new EstateAgentDto
                {
                    IdEstateAgent = item.Field<int>(0),
                    Image = item.Field<byte[]>(1),
                    IdPerson = item.Field<int>(2),
                    IdentityDocument = item.Field<string>(3),
                    IdDocumentType = item.Field<int>(4),
                 
                    DocumentType = new DocumentTypeDto
                    {
                        Id = item.Field<int>(4),
                        Name = item.Field<string>(5),
                    },
                    Name = item.Field<string>(6),
                    LastName = item.Field<string>(7),
                    DateBorn = item.Field<DateTime>(8),
                    Mail = item.Field<string>(9),
                    DateCreate = item.Field<DateTime>(10)
                });
            }
            return estateAgents;
        }

        public async Task<List<SaleManagerDto>> GetSaleManagerService()
        {
            List<SaleManagerDto> saleManagerDtos = new List<SaleManagerDto>();
           var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinEncargadoVentaPersona));
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                saleManagerDtos.Add(new SaleManagerDto
                {
                    IdSaleManager = item.Field<int>(0),
                    IdPerson = item.Field<int>(1),
                    IdDocumentType = item.Field<int>(2),
                    DocumentType = new DocumentTypeDto
                    {
                        Id = item.Field<int>(2),
                        Name = item.Field<string>(3),
                    },
                    Name = item.Field<string>(4),
                    LastName = item.Field<string>(5),
                    DateBorn = item.Field<DateTime>(6),
                    Mail = item.Field<string>(7),
                    DateCreate = item.Field<DateTime>(8),
                    Phone = item.Field<string>(9),
                });
            }
            return saleManagerDtos;
        }

        public async Task<PersonDto> LogInt(string name, string document)
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.LoginProc,new object[] { name,document}));
            PersonDto dtos = new PersonDto();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos = new PersonDto
                {
                    IdPerson = item.Field<int>(0),
                    IdDocumentType = item.Field<int>(1),
                    DocumentType = new DocumentTypeDto
                    {
                        Id = item.Field<int>(1),
                        Name = item.Field<string>(2),
                    },
                    Name = item.Field<string>(3),
                    LastName = item.Field<string>(4),
                    DateBorn = item.Field<DateTime>(5),
                    Mail = item.Field<string>(6),
                    DateCreate = item.Field<DateTime>(7),
                    Phone = item.Field<string>(8),
                };
            }
            return dtos;
        }

        public async Task<string> SaveAttorney(AttorneyDto attorneyDto)
        {
            object[] person = new object[] {attorneyDto.IdPerson,attorneyDto.IdentityDocument, attorneyDto.IdDocumentType, attorneyDto.Name, attorneyDto.LastName, attorneyDto.Mail, attorneyDto.Phone, attorneyDto.DateBorn };
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblAbogado, person));
             
        }

        public async Task<string> SaveCustomer(CustomerDto customerDto)
        {
            object[] person = new object[] { customerDto.IdPerson, customerDto.IdentityDocument, customerDto.IdDocumentType, customerDto.Name, customerDto.LastName, customerDto.Mail, customerDto.Phone, customerDto.DateBorn };
            return await  Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblCliente, person));
        }

        public async Task<string> SaveEstateAgent(EstateAgentDto estateAgentDto)
        {
            object[] person = new object[] { estateAgentDto.IdPerson, estateAgentDto.Image, estateAgentDto.IdentityDocument,estateAgentDto.IdDocumentType, estateAgentDto.Name, estateAgentDto.LastName, estateAgentDto.Mail, estateAgentDto.Phone, estateAgentDto.DateBorn };
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblAgenteInmobilario, person));
        }


        public async Task<string> SaveSaleManager(SaleManagerDto saleManagerDto)
        {
            object[] person = new object[] { saleManagerDto.IdPerson, saleManagerDto.IdDocumentType, saleManagerDto.IdentityDocument, saleManagerDto.Name, saleManagerDto.LastName, saleManagerDto.Mail, saleManagerDto.Phone, saleManagerDto.DateBorn };
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblEncargadoDeVenta, person));
        }

        public async Task<string> UpdatePerson(PersonDto personDto)
        {
            object[] person = new object[] { personDto.IdPerson, personDto.IdentityDocument, personDto.IdDocumentType, personDto.Name, personDto.LastName, personDto.Mail, personDto.Phone, personDto.DateBorn };
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateTblPersona, person));
        }
    }
}
