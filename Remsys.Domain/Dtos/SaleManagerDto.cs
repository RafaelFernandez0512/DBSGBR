using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class SaleManagerDto:PersonDto
    {
        [JsonProperty("IdSaleManager")]
        public int IdSaleManager { get; set; }
    }
}
