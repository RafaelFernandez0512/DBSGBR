using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public interface IAddressService
    {
        Task<string> SaveCountry(CountryDto countryDto);
        Task<string> SaveProvince(ProvinceDto provinceDto);
        Task<string> SaveAddress(AddressDto  addressDto);

        Task<string> UpdateCountry(CountryDto countryDto);
        Task<string> UpdateProvince(ProvinceDto provinceDto);
        Task<string> UpdateAddress(AddressDto addressDto);
        Task<string> DeleteCountry(int id);
        Task<string> DeleteProvince(int id);
        Task<string> DeleteAddress(int id);

        Task<List<CountryDto>> GetCountry();
        Task<List<ProvinceDto>> GetProvince();
        Task<List<AddressDto>> GetAddress();
    }
}
