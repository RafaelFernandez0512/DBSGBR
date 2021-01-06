using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class ProvinceDto
    {
        public int IdProvince { get; set; }
        [Required]
        public int IdCountry { get; set; }
        public CountryDto CountryDto  { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
