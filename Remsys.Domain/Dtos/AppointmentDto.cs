using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remsys.Domain.Dtos
{
   public class AppointmentDto
    {
        [JsonProperty("IdAppointment")]
        public int IdAppointment { get; set; }
        [JsonProperty("IdShedule")]
        public int IdShedule { get; set; }
        [JsonProperty("IdStateAppointment")]
        public int IdStateAppointment { get; set; }
        [JsonProperty("StateAppointment")]
        public StateAppointmentDto StateAppointment { get; set; }
        [JsonProperty("ScheduleDto")]
        public ScheduleDto ScheduleDto  { get; set; }
        [JsonProperty("IdSaleManager")]
        public int IdSaleManager { get; set; }
        [JsonProperty("IdCustomer")]
        public int IdCustomer { get; set; }
        [JsonProperty("IdProperty")]
        public int IdProperty { get; set; }
        [JsonProperty("DateCreate")]
        public DateTime DateCreate { get; set; }
    }
}
