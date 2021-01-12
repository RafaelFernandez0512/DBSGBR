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
    public class AttorneyController : ControllerBase
    {
        IPersonService _personService;
        public AttorneyController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<AttorneyController>
        [HttpGet]
        public async Task<IEnumerable<AttorneyDto>> Get()
        {
            try
            {
                return await _personService.GetAttorneyService();
            }
            catch (Exception)
            {

                return null;
            }
           
        }

        // GET api/<AttorneyController>/5
        [HttpGet("{id}")]
        public async Task<AttorneyDto> GetById(int id)
        {
            var persons = await Get();
            if (persons != null)
            {
                var person = persons.Where(e => e.IdPerson == id);
                return persons.FirstOrDefault();

            }
            return null;
        }

        // POST api/<AttorneyController>
        [HttpPost]
        public async Task<string> Post([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.SaveAttorney(attorneyDto);
        }

        // PUT api/<AttorneyController>/5
        [HttpPut]
        public async Task<string> Put([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.UpdatePerson(attorneyDto);
        }

        // DELETE api/<AttorneyController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _personService.DeleteAttorney(id);
        }
    }
}
