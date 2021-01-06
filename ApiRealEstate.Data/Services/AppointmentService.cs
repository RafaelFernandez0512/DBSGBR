using ApiRealEstate.Data.Dtos;
using ApiRealEstate.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ApiRealEstate.Data.Services
{
    public class AppointmentService : BaseService, IAppointmentService
    {
        public async Task<string> DeleteAppointment(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblCita, new object[] { id }));
        }

        public async Task<string> DeleteStateAppointment(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblEstadoCita, new object[] { id }));
        }

        public async Task<List<AppointmentDto>> GetAppointments()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinHorario_Cita_Estado_Cita));
            List<AppointmentDto> dtos = new List<AppointmentDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new AppointmentDto
                {
                    IdAppointment = item.Field<int>(0),
                    IdStateAppointment = item.Field<int>(1),
                    StateAppointment = new StateAppointmentDto()
                    {
                        Id = item.Field<int>(1),
                        Name = item.Field<string>(2)

                    },
                    IdShedule = item.Field<int>(3),
                    ScheduleDto = new ScheduleDto()
                    {
                        Id = item.Field<int>(3),
                        VisitTime = item.Field<DateTime>(4),
                        EndVisitTime = item.Field<DateTime>(5),

                    },
                    IdCustomer = item.Field<int>(6),
                    IdProperty = item.Field<int>(7),
                    IdSaleManager = item.Field<int>(8),
                  
                   



                });
            }
            return dtos;
        }

        public async Task<List<StateAppointmentDto>> GetStateAppointments()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarEstadoCita));
            List<StateAppointmentDto> dtos = new List<StateAppointmentDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new StateAppointmentDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),
                });
            }
            return dtos;
        }

        public async Task<string> SaveAppointment(AppointmentDto appointmentDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblCita, new object[] { appointmentDto.IdAppointment, appointmentDto.ScheduleDto.VisitTime, appointmentDto.ScheduleDto.EndVisitTime, appointmentDto.IdStateAppointment, appointmentDto.IdCustomer, appointmentDto.IdSaleManager, appointmentDto.IdProperty }));
        }

        public async Task<string> SaveStateAppointment(StateAppointmentDto stateAppointmentDto )
        { 
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblEstadoCita, new object[] { stateAppointmentDto.Name }));
        }
    }
}
