using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class ReportDto
    {
        public int IdReport { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int IdReportType { get; set; }
        public ReportTypeDto ReportType { get; set; }
        [Required]
        public int IdSale { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
