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
    public class ReportController : ControllerBase
    {
        IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        // GET: api/<ReportController>
        [HttpGet]
        public async Task<IEnumerable<ReportDto>> Get()
        {
            return await _reportService.GetReports();
        }
        [HttpGet("TypeReport")]
        public async Task<IEnumerable<ReportTypeDto>> GetTypeReport()
        {

            return await _reportService.GetTypesReports();
        }
        // GET api/<ReportController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReportController>
        [HttpPost]
        public async Task<string> Post([FromBody] ReportDto reportDto)
        {
            try
            {
              return  await _reportService.SaveReport(reportDto);
            }
            catch (Exception ex)
            {

                return ex.Message ;
            }
        }
        [HttpPost("TypeReport")]
        public async Task<string> PostTypeReport([FromBody] ReportTypeDto reportDto)
        {
            try
            {
                return await _reportService.SaveTypeReport(reportDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        // PUT api/<ReportController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReportController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            try
            {
                return await _reportService.DeleteReport(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("TypeReport/{id}")]
        public async Task<string> DeleteTypeReport(int id)
        {
            try
            {
                return await _reportService.DeleteTypeReport(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
