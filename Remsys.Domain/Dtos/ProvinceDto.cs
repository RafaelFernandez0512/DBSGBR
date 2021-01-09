using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class ProvinceDto
    {
        [JsonProperty("IdProvince")]
        public int IdProvince { get; set; }
        [JsonProperty("IdCountry")]
        public int IdCountry { get; set; }
        [JsonProperty("CountryDto")]
        public CountryDto CountryDto  { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
