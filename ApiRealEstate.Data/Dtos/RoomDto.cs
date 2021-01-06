using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int IdTypeRoom { get; set; }
        public TypeRoomDto TypeRoom { get; set; }
        public int IdPropery { get; set; }
        public PropertyDto Property { get; set; }
    }
}
