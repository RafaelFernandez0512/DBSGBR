using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class AddressDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("idProvince")]
        public int IdProvince { get; set; }
        [JsonProperty("Province")]
        public ProvinceDto Province { get; set; }
    }
}
