using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }
        [Required]
        public int IdEstateAgent { get; set; }
        [Required]
        public int IdPropertyType { get; set; }
        public PropertyTypeDto PropertyTypeDto  { get; set; }
        [Required]
        public int IdProperyOperationType { get; set; }
        public ProperyOperationTypeDto ProperyOperationTypeDto  { get; set; }
        [Required]
        public int IdAttorney { get; set; }
        [Required]
        public int IdAddress { get; set; }
        [Required]
        public decimal PropertyValue { get; set; }
        [Required]
        public int IdRoom { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int Rate { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int QuantityMeters { get; set; }
    }
}
