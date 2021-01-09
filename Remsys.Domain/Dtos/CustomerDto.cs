using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class CustomerDto:PersonDto
    {
        [JsonProperty("IdCustomer")]
        public int IdCustomer { get; set; }
    }
}
