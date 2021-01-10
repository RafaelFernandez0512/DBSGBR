using Microsoft.AspNetCore.Mvc;
using Remsys.Data.Services;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Remsys.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        IPersonService _personService;
        public LogInController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<LogInController>
        [HttpGet("{name}/{idDocumento}")]
        public Task<PersonDto> Get(string name,string idDocumento)
        {
            return _personService.LogInt(name, idDocumento);
        }

    }
}
