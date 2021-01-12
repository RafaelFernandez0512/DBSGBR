using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
    public interface IReportServiceApi
    {
        [Get("/api/Report")]
        Task<HttpResponseMessage> GetReports();
        [Get("/api/Report/TypeReport")]
        Task<HttpResponseMessage> GetTypesReports();
    }
}
