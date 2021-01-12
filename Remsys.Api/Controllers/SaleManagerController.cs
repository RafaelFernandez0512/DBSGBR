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
    public class SaleManagerController : ControllerBase
    {
        IPersonService _personService;
        public SaleManagerController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<SaleManagerController>
        [HttpGet]
        public async Task<IEnumerable<SaleManagerDto>> Get()
        {
            try
            {
                return await _personService.GetSaleManagerService();
            }
            catch (Exception)
            {

                return null;
            }
           
        }

        // GET api/<SaleManagerController>/5
        [HttpGet("{id}")]
        public async Task<SaleManagerDto> GetById(int id)
        {
            var persons = await Get();
            if (persons != null)
            {
                var person = persons.Where(e => e.IdPerson == id);
                return persons.FirstOrDefault();

            }
            return null;
        }

        // POST api/<SaleManagerController>
        [HttpPost]
        public async Task<string> Post([FromBody] SaleManagerDto saleManagerDto)
        {
            try
            {
                return await _personService.SaveSaleManager(saleManagerDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        // PUT api/<SaleManagerController>/5
        [HttpPut]
        public async Task<string> Put([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.UpdatePerson(attorneyDto);
        }
        // DELETE api/<SaleManagerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            try
            {
                 await _personService.DeleteSaleManager(id);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
