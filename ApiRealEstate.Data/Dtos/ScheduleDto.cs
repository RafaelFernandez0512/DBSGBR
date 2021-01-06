using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
    public class ScheduleDto
    {
        public int  Id { get; set; }
        public DateTime VisitTime { get; set; }
        public DateTime EndVisitTime { get; set; }
    }
}
