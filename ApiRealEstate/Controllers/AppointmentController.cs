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
    public class AppointmentController : ControllerBase
    {
        IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        [HttpGet]
        public async Task<IEnumerable<AppointmentDto>> GetAppointment()
        {
            try
            {
                return await _appointmentService.GetAppointments();
            }
            catch (Exception ex)
            {

                return null;
            }
           
        }
        [HttpGet("StateAppointment")]
        public async Task<IEnumerable<StateAppointmentDto>> GetStateAppointment()
        {
            try
            {
                return await _appointmentService.GetStateAppointments();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<string> PostAppointment(AppointmentDto appointmentDto)
        {
          return  await _appointmentService.SaveAppointment(appointmentDto);
        }
        [HttpPost("StateAppointment")]
        public async Task<string> PostStateAppointment(StateAppointmentDto appointmentDto )
        {
            return await _appointmentService.SaveStateAppointment(appointmentDto);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _appointmentService.DeleteAppointment(id);
        }
        [HttpDelete("StateAppointment/{id}")]
        public async Task<string> DeleteStateAppointment(int id)
        {
            return await _appointmentService.DeleteStateAppointment(id);
        }
    }
}
