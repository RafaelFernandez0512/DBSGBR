using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class EstateAgentDto:PersonDto
    {
        public int IdEstateAgent { get; set; }
        public string Image { get; set; }
    }
}
