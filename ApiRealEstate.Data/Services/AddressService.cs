using ApiRealEstate.Data.Dtos;
using ApiRealEstate.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ApiRealEstate.Data.Services
{
    public class AddressService : BaseService, IAddressService
    {
        public async Task<string> DeleteAddress(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblCita, new object[] { id }));
        }

        public async Task<string> DeleteCountry(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblCita, new object[] { id }));
        }

        public async Task<string> DeleteProvince(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblCita, new object[] { id }));
        }

        public async Task<List<AddressDto>> GetAddress()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinDireccion));
            List<AddressDto> dtos = new List<AddressDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new AddressDto
                {
                    Id = item.Field<int>(0),
                    IdProvince = item.Field<int>(1),
                    Province = new ProvinceDto {
                        IdProvince = item.Field<int>(1),
                        Name = item.Field<string>(2),
                        IdCountry = item.Field<int>(3),
                        CountryDto = new CountryDto()
                        {
                            Id = item.Field<int>(3),
                            Name = item.Field<string>(4),

                        }

                    }

                });
            }
            return dtos;
        }

        public async Task<List<CountryDto>> GetCountry()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTblPais));
            List<CountryDto> dtos = new List<CountryDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new CountryDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),
                });
            }
            return dtos;
        }

        public async Task<List<ProvinceDto>> GetProvince()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinProvincia));
            List<ProvinceDto> dtos = new List<ProvinceDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ProvinceDto
                {
                    IdProvince = item.Field<int>(0),
                    Name = item.Field<string>(1),
                    IdCountry = item.Field<int>(2),
                    CountryDto = new CountryDto() { 
                        Id= item.Field<int>(2),
                        Name=  item.Field<string>(3),

                    }


                });
            }
            return dtos;
        }

        public async Task<string> SaveAddress(AddressDto addressDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblEstadoCita, new object[] { addressDto.IdProvince }));
        }

        public  async  Task<string> SaveCountry(CountryDto countryDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblEstadoCita, new object[] {  countryDto.Name }));
        }

        public async Task<string> SaveProvince(ProvinceDto provinceDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblProvincia, new object[] {  provinceDto.Name }));
        }
    }
}
