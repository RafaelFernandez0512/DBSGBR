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
    public class SaleController : ControllerBase
    {
        ISaleService _saleService;
        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        // GET: api/<SaleController>
        [HttpGet]
        public async Task<IEnumerable<SaleDto>> Get()
        {
            try
            {
               return await _saleService.GetSales();
            }
            catch (Exception)
            {

                return null;
            }
        }

        // GET api/<SaleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SaleController>
        [HttpPost]
        public async Task<string> Post([FromBody] SaleDto saleDto )
        {
            return await _saleService.SaveSale(saleDto);
        }

        // PUT api/<SaleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SaleController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            try
            {
                return await _saleService.DeleteSale(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }
    }
}
