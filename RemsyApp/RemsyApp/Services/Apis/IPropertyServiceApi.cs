using Refit;
using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services.Apis
{
   public interface IPropertyServiceApi
    {

        [Post("/api/Property/Property")]
        Task<HttpResponseMessage> SaveProperty([Body]PropertyDto propertyDto);
        [Put("/api/Property/Property")]
        Task<HttpResponseMessage> UpdateTypeProperty([Body] PropertyTypeDto propertyTypeDto);


        //List
        [Get("/api/Property/PropertyTypeOperation")]
        Task<HttpResponseMessage> GetTypeOperation();
        [Get("/api/Property/PropertyType")]
        Task<HttpResponseMessage> GetTypeProperty();

        [Get("/api/Property/TypeRoom")]
        Task<HttpResponseMessage> GetTypeRoom();
        [Get("/api/Property/Property")]
        Task<HttpResponseMessage> GetProperty();
        [Get("/api/Property/Property/{id}")]
        Task<HttpResponseMessage> GetProperty(string id);


    }
}
