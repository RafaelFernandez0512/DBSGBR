using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class SaleDto
    {
        public int Id { get; set; }
        [Required]
        public int IdSaleManager { get; set; }
        [Required]
        public int IdContract { get; set; }
        [Required]
        public int IdAppointment { get; set; }

    }
}
