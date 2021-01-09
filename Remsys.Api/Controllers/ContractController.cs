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
    public class ContractController : ControllerBase
    {
        ISaleService _saleService;
        public ContractController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        // GET: api/<ContractController>
        [HttpGet]
        public async Task<IEnumerable<ContractDto>> Get()
        {
            return await _saleService.GetContracts();
        }
        [HttpGet("ContractsType")]
        public async Task<IEnumerable<ContractTypeDto>> GetTypeContract()
        {
            return await _saleService.GetTypesContract();
        }

        // GET api/<ContractController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContractController>
        [HttpPost]
        public async Task<string> Post([FromBody] ContractDto contractDto)
        {
            try
            {
                return await _saleService.SaveContract(contractDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("ContractsType")]
        public async Task<string> PostTypeContract([FromBody] ContractTypeDto ContractTypeDto)
        {
            try
            {
                return await _saleService.SaveTypeContract(ContractTypeDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        // PUT api/<ContractController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContractController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            try
            {
                return await _saleService.DeleteContract(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("ContractsType/{id}")]
        public async Task<string> DeleteContractsType(int id)
        {
            try
            {
                return await _saleService.DeleteTypeContract(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
