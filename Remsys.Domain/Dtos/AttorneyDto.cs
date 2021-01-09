using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class AttorneyDto:PersonDto
    {
        [JsonProperty("IdAttorney")]
        public int IdAttorney { get; set; }
    }
}
