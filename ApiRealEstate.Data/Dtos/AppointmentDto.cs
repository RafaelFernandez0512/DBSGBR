using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiRealEstate.Data.Dtos
{
   public class AppointmentDto
    {
        public int IdAppointment { get; set; }
 
        public int IdShedule { get; set; }
        public int IdStateAppointment { get; set; }
        public StateAppointmentDto StateAppointment { get; set; }
        public ScheduleDto ScheduleDto  { get; set; }
        public int IdSaleManager { get; set; }
        public int IdCustomer { get; set; }
        public int IdProperty { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
