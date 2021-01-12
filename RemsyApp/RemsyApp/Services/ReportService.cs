using RemsyApp.Services.Apis;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
    public class ReportService : BaseService, IReportService
    {
        
         IApiClient<IReportServiceApi> _apiClient;
        public ReportService(IApiClient<IReportServiceApi> apiClient)
        {
            _apiClient = apiClient;
        }
         public async Task<Response<List<ReportDto>>> GetReports()
        {
            var response = await RemoteRequestAsync<List<ReportDto>>(_apiClient.Client.GetReports());
            return response;
        }

        public async Task<Response<List<ReportTypeDto>>> GetTypesReports()
        {
            var response = await RemoteRequestAsync<List<ReportTypeDto>>(_apiClient.Client.GetTypesReports());
            return response;
        }
    }
}
