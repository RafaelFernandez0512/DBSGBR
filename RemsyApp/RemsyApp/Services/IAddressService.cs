using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public interface IAddressService
    {
        Task<Response<List<CountryDto>>> GetCountry();
        Task<Response<List<ProvinceDto>>> GetProvince();
        Task<Response<List<AddressDto>>> GetAddress();
    }
}
