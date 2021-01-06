using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
   public class ContractDto
    {
        public int Id { get; set; }
        [Required]
        public int IdContractType { get; set; }
        public ContractTypeDto ContractTypeDto  { get; set; }
        [Required]
        public int IdAttorney { get; set; }
        public AttorneyDto AttorneyDto  { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        public string File { get; set; }
    }
}
