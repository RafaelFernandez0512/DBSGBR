using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
   public class ContractDto
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("IdContractType")]
        public int IdContractType { get; set; }
        [JsonProperty("ContractTypeDto")]
        public ContractTypeDto ContractTypeDto  { get; set; }
        [JsonProperty("IdAttorney")]
        public int IdAttorney { get; set; }
        [JsonProperty("AttorneyDto")]
        public AttorneyDto AttorneyDto  { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("File")]
        public string File { get; set; }
    }
}
