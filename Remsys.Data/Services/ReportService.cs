using Remsys.Domain.Dtos;
using Remsys.Data.Services;
using Remsys.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public class ReportService : BaseService, IReportService
    {
        public async Task<string> DeleteReport(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblReporte, new object[] { id }));
        }

        public async Task<string> DeleteTypeReport(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTipoReporte, new object[] { id }));
        }

        public async Task<List<ReportDto>> GetReports()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinReporte));
            List<ReportDto> dtos = new List<ReportDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ReportDto
                {
                    IdReport = item.Field<int>(0),
                    Title = item.Field<string>(1),
                    Description = item.Field<string>(2),
                    IdSale = item.Field<int>(3),
                    CreateDate = item.Field<DateTime>(4),
                    ReportType = new ReportTypeDto { 
                    Id =  item.Field<int>(5),
                    Name =  item.Field<string>(4),
                    } ,
                    IdReportType = item.Field<int>(5),
                });
            }
            return dtos;
        }

        public async Task<List<ReportTypeDto>> GetTypesReports()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTiposReporte));
            List<ReportTypeDto> dtos = new List<ReportTypeDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ReportTypeDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),
                });
            }
            return dtos;
        }

        public async Task<string> SaveReport(ReportDto reportDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblReporte, new object[] { reportDto.IdReportType, reportDto.IdSale, reportDto.Title, reportDto.Description }));
        }

        public async Task<string> SaveTypeReport(ReportTypeDto reportTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblTipoReporte, new object[] { reportTypeDto.Name }));
        }
    }
}
