using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class EstateAgentDto:PersonDto
    {
        [JsonProperty("IdEstateAgent")]
        public int IdEstateAgent { get; set; }
        [JsonProperty("Image")]
        public byte[] Image { get; set; }
    }
}
