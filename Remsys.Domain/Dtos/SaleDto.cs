using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class SaleDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("IdSaleManager")]
        public int IdSaleManager { get; set; }
        [JsonProperty("IdContract")]
        public int IdContract { get; set; }
        [JsonProperty("IdAppointment")]
        public int IdAppointment { get; set; }

    }
}
