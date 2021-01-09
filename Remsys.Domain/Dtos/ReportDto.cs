using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
    public class ReportDto
    {
        [JsonProperty("IdReport")]
        public int IdReport { get; set; }
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("IdReportType")]
        public int IdReportType { get; set; }
        [JsonProperty("ReportType")]
        public ReportTypeDto ReportType { get; set; }
        [JsonProperty("IdSale")]
        public int IdSale { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("CreateDate")]

        public DateTime CreateDate { get; set; }
    }
}
