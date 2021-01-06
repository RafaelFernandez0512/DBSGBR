using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class PersonDto
    {
        public int IdPerson { get; set; }
        [Required]
        public int IdDocumentType { get; set; }
        public DocumentTypeDto DocumentType { get; set; }
        [Required]
        public string IdentityDocument { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateBorn { get; set; }
        public DateTime DateCreate { get; set; }
        [Required]
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
