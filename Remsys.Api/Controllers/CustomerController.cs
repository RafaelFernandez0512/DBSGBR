using Remsys.Domain.Dtos;
using Remsys.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Remsys.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IPersonService _personService;
        public CustomerController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> GetCustomer()
        {
            try
            {
                return await _personService.GetCustomerService();
            }
            catch (Exception)
            {

                return null;
            } 
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<CustomerDto> GetById(int id)
        {
            var customers =await GetCustomer();
            if (customers!=null)
            {
                var customer = customers.Where(e => e.IdPerson == id);
              return customer.FirstOrDefault();
             
            }
            return null; 
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<string> Post([FromBody] CustomerDto customerDto)
        {
            return await _personService.SaveCustomer(customerDto);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public async Task<string> Put([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.UpdatePerson(attorneyDto);
        }
        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _personService.DeleteCustomer(id);
        }
    }
}
