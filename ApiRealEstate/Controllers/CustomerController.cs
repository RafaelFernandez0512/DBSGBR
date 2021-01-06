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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<string> Post([FromBody] CustomerDto customerDto)
        {
            return await _personService.SaveCustomer(customerDto);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _personService.DeleteCustomer(id);
        }
    }
}
