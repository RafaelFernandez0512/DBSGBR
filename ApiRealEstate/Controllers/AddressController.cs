using ApiRealEstate.Data.Dtos;
using ApiRealEstate.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        IAddressService _addressService;
        public AddressController(IAddressService addressService )
        {
            _addressService = addressService;
        }
        // GET: api/<AddressController>
        [HttpGet("Country")]
        public async Task<IEnumerable<CountryDto>> GetCountry()
        {
            return  await _addressService.GetCountry();
        }
        // GET: api/<AddressController>
        [HttpGet("Province")]
        public async Task<IEnumerable<ProvinceDto>> GetProvince()
        {
            return await _addressService.GetProvince();
        }
        // GET: api/<AddressController>
        [HttpGet("Address")]
        public async Task<IEnumerable<AddressDto>> GetAddress()
        {
            return await _addressService.GetAddress();
        }



        // POST api/<AddressController>
        [HttpPost("Country")]
        public async Task<string> PostCountry([FromBody] CountryDto countryDto )
        {
            try
            {
                return await _addressService.SaveCountry(countryDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("Province")]
        public async Task<string> PostProvince([FromBody] ProvinceDto provinceDto)
        {
            try
            {
                return await _addressService.SaveProvince(provinceDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("Address")]
        public async Task<string> PostAddress([FromBody] AddressDto addressDto)
        {
            try
            {
                return await _addressService.SaveAddress(addressDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        // PUT api/<AddressController>/5

        // DELETE api/<AddressController>/5
        [HttpDelete("Province{id}")]
        public async Task<string> DeleteProvince(int id)
        {
            try
            {
                return await _addressService.DeleteProvince(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("Address/{id}")]
        public async Task<string> DeleteAddress(int id)
        {
            try
            {
                return await _addressService.DeleteAddress(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("Country/{id}")]
        public async Task<string> DeleteCountry(int id)
        {
            try
            {
                return await _addressService.DeleteCountry(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
