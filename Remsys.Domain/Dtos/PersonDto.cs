using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class PersonDto
    {
        [JsonProperty("IdPerson")]
        public int IdPerson { get; set; }
        [JsonProperty("IdDocumentType")]
        public int IdDocumentType { get; set; }
        [JsonProperty("DocumentType")]
        public DocumentTypeDto DocumentType { get; set; }
        [JsonProperty("IdentityDocument")]
        public string IdentityDocument { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("DateBorn")]
        public DateTime DateBorn { get; set; }
        [JsonProperty("DateCreate")]
        public DateTime DateCreate { get; set; }
        [JsonProperty("Mail")]
        public string Mail { get; set; }
        [JsonProperty("Phone")]
        public string Phone { get; set; }
    }
}
