using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RemsyApp.Services
{
   public interface IPropertyService
    {

        Task<Response<string>> SaveProperty(PropertyDto propertyDto);




        //List
        Task<Response<List<ProperyOperationTypeDto>>> GetTypeOperation();

        Task<Response<List<PropertyTypeDto>>> GetTypeProperty();

        Task<Response<List<TypeRoomDto>>> GetTypeRoom();

        Task<Response<List<PropertyDto>>> GetProperty();
        Task<Response<List<PropertyDto>>> GetProperty(string id);


    }
}
