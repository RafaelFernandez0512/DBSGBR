using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
    public interface IAddressServiceApi
    {

        [Get("/api/Address/Country")]
        Task<HttpResponseMessage> GetCountry();
        [Get("/api/Address/Country")]
        Task<HttpResponseMessage> GetProvince();
        [Get("/api/Address/Country")]
        Task<HttpResponseMessage> GetAddress();
    }
}
