using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class RoomDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Quantity")]
        public int Quantity { get; set; }
        [JsonProperty("IdTypeRoom")]
        public int IdTypeRoom { get; set; }
        [JsonProperty("TypeRoom")]
        public TypeRoomDto TypeRoom { get; set; }
        [JsonProperty("IdPropery")]
        public int IdPropery { get; set; }
        [JsonProperty("Property")]
        public PropertyDto Property { get; set; }
        [JsonIgnore]
        public string Icon { get; set; }
    }
}
