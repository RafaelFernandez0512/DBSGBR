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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AttorneyController>
        [HttpPost]
        public async Task<string> Post([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.SaveAttorney(attorneyDto);
        }

        // PUT api/<AttorneyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AttorneyController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _personService.DeleteAttorney(id);
        }
    }
}
