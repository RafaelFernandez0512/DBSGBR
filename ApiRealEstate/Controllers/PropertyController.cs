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
    public class PropertyController : ControllerBase
    {
        IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        // GET: api/<PropertyController>
        [HttpGet("Property")]
        public async Task<IEnumerable<PropertyDto>> GetProperty()
        {
            return await _propertyService.GetProperty();
        }
        [HttpGet("PropertyType")]
        public async Task<IEnumerable<PropertyTypeDto>> GetTypeProperty()
        {
            return await _propertyService.GetTypeProperty();
        }
        [HttpGet("PropertyTypeOperation")]
        public async Task<IEnumerable<ProperyOperationTypeDto>> GetTypeOperation()
        {
            return await _propertyService.GetTypeOperation();
        }
        [HttpGet("TypeRoom")]
        public async Task<IEnumerable<TypeRoomDto>> GetTypeRoom()
        {
            return await _propertyService.GetTypeRoom();
        }
        [HttpGet("Room/{Id}")]
        public async Task<IEnumerable<RoomDto>> GetRoom(int idProperty)
        {
            return await _propertyService.GetRoom(idProperty);
        }

        // POST api/<PropertyController>
        [HttpPost("Property")]
        public async Task<string> PostProperty([FromBody] PropertyDto propertyDto)
        {
            try
            {
                return await _propertyService.SaveProperty(propertyDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("PropertyType")]
        public async Task<string> PostPropertyType([FromBody] PropertyTypeDto propertyTypeDto)
        {
            try
            {
                return await _propertyService.SaveTypeProperty(propertyTypeDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("ProperyOperationType")]
        public async Task<string> PostProperyOperationType([FromBody] ProperyOperationTypeDto properyOperationTypeDto )
        {
            try
            {
                return await _propertyService.SaveTypeOperation(properyOperationTypeDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("Room")]
        public async Task<string> PostRoom([FromBody] RoomDto  roomDto)
        {
            try
            {
                return await _propertyService.SaveRoom(roomDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPost("TypeRoom")]
        public async Task<string> PostTypeRoom([FromBody] TypeRoomDto TypeRoomDto)
        {
            try
            {
                return await _propertyService.SaveTypeRoom(TypeRoomDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        // DELETE api/<PropertyController>/5
        [HttpDelete("Property/{id}")]
        public async Task<string> DeleteProperty(int id)
        {
            try
            {
                return await _propertyService.DeleteProperty(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("TypeProperty/{id}")]
        public async Task<string> DeleteTypeProperty(int id)
        {
            try
            {
                return await _propertyService.DeleteTypeProperty(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("TypeOperation/{id}")]
        public async Task<string> DeleteTypeOperation(int id)
        {
            try
            {
                return await _propertyService.DeleteTypeOperation(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("Room/{id}")]
        public async Task<string> DeleteRoom(int id)
        {
            try
            {
                return await _propertyService.DeleteRoom(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpDelete("TypeRoom/{id}")]
        public async Task<string> DeleteTypeRoom(int id)
        {
            try
            {
                return await _propertyService.DeleteTypeRoom(id);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
