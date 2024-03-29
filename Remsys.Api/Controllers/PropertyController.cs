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
        [HttpGet("Property/{Id}")]
        public async Task<IEnumerable<PropertyDto>> GetProperty(string Id)
        {
            var properties = await _propertyService.GetProperty();
            return await Task.FromResult(properties.Where(e => e.IdEstateAgent == int.Parse(Id)));
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
        // UPDATE api
        // POST api/<PropertyController>
        [HttpPut("Property")]
        public async Task<string> PutProperty([FromBody] PropertyDto propertyDto)
        {
            try
            {
                return await _propertyService.UpdateProperty(propertyDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPut("PropertyType")]
        public async Task<string> PutPropertyType([FromBody] PropertyTypeDto propertyTypeDto)
        {
            try
            {
                return await _propertyService.UpdateTypeProperty(propertyTypeDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPut("ProperyOperationType")]
        public async Task<string> PutProperyOperationType([FromBody] ProperyOperationTypeDto properyOperationTypeDto)
        {
            try
            {
                return await _propertyService.UpdateTypeOperation(properyOperationTypeDto);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        [HttpPut("Room")]
        public async Task<string> PutRoom([FromBody] RoomDto roomDto)
        {
            try
            {
                return await _propertyService.UpdateRoom(roomDto);
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
