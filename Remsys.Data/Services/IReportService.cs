using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public interface IReportService
    {
        Task<string> SaveTypeReport( ReportTypeDto reportTypeDto);
        Task<string> SaveReport(ReportDto reportDto);
        Task<string> DeleteTypeReport(int id);
        Task<string> DeleteReport(int id);
        Task<List<ReportDto>> GetReports();
        Task<List<ReportTypeDto>> GetTypesReports();
    }
}
