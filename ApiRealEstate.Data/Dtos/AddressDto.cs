using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        [Required]
        public int IdProvince { get; set; }
        public ProvinceDto Province { get; set; }
    }
}
