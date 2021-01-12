using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public interface IReportService
    {
        Task<Response<List<ReportDto>>> GetReports();
        Task<Response<List<ReportTypeDto>>> GetTypesReports();
    }
}
