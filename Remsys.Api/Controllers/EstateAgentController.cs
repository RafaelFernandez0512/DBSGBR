﻿using Remsys.Domain.Dtos;
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
    public class EstateAgentController : ControllerBase
    {
        IPersonService _personService;
        public EstateAgentController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<EstateAgentController>
        [HttpGet]
        public async Task<IEnumerable<EstateAgentDto>> Get()
        {
            try
            {
              return await  _personService.GetEstateAgentService();
            }
            catch (Exception)
            {

                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<EstateAgentDto> GetById(int id)
        {
            var persons = await Get();
            if (persons != null)
            {
                var person = persons.Where(e => e.IdPerson == id);
                return persons.FirstOrDefault();

            }
            return null;
        }

        // POST api/<EstateAgentController>
        [HttpPost]
        public async Task<string> Post([FromBody] EstateAgentDto estateAgentDto)
        {
            return await _personService.SaveEstateAgent(estateAgentDto);
        }

        // PUT api/<EstateAgentController>/5
        [HttpPut]
        public async Task<string> Put([FromBody] AttorneyDto attorneyDto)
        {
            return await _personService.UpdatePerson(attorneyDto);
        }
        // DELETE api/<EstateAgentController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _personService.DeleteEstateAgent(id);
        }
    }
}
