using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class ScheduleDto
    {
        [JsonProperty("Id")]
        public int  Id { get; set; }
        [JsonProperty("VisitTime")]
        public DateTime VisitTime { get; set; }
        [JsonProperty("EndVisitTime")]
        public DateTime EndVisitTime { get; set; }
    }
}
