using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class ProperyOperationTypeDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
