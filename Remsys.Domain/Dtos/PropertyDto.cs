using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class PropertyDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("IdEstateAgent")]
        public int IdEstateAgent { get; set; }
        [JsonProperty("IdPropertyType")]
        public int IdPropertyType { get; set; }
        [JsonProperty("PropertyTypeDto")]
        public PropertyTypeDto PropertyTypeDto  { get; set; }
        [JsonProperty("IdProperyOperationType")]
        public int IdProperyOperationType { get; set; }
        [JsonProperty("ProperyOperationTypeDto")]
        public ProperyOperationTypeDto ProperyOperationTypeDto  { get; set; }
        [JsonProperty("IdAttorney")]
        public int IdAttorney { get; set; }
        [JsonProperty("IdAddress")]
        public int IdAddress { get; set; }
        [JsonProperty("Address")]
        public AddressDto Address { get; set; }
        [JsonProperty("PropertyValue")]
        public decimal PropertyValue { get; set; }
        [JsonProperty("IdRoom")]
        public int IdRoom { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("Estado")]
        public bool Estado { get; set; }
        [JsonProperty("Rate")]
        public int Rate { get; set; }
        [JsonProperty("Image")]
        public byte[] Image { get; set; }
        [JsonProperty("QuantityMeters")]
        public decimal QuantityMeters { get; set; }
        [JsonProperty("EstateAgent")]
        public EstateAgentDto EstateAgent  { get; set; }
        [JsonProperty("Room")]
        public List<RoomDto> Rooms { get; set; }
    }
}
