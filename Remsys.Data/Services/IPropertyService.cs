using Remsys.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
   public interface IPropertyService
    {
        Task<string> SaveTypeOperation(ProperyOperationTypeDto properyOperationTypeDto);

        Task<string> SaveTypeProperty(PropertyTypeDto propertyTypeDto);

        Task<string> SaveTypeRoom(TypeRoomDto typeRoomDto);

        Task<string> SaveRoom(RoomDto roomDto);
        Task<string> SaveProperty(PropertyDto propertyDto);


        //Delete

        Task<string> DeleteTypeOperation(int id);

        Task<string> DeleteTypeProperty(int id);

        Task<string> DeleteTypeRoom(int id);

        Task<string> DeleteRoom(int id);
        Task<string> DeleteProperty(int id);

        //List
        Task<List<ProperyOperationTypeDto>> GetTypeOperation();

        Task<List<PropertyTypeDto>> GetTypeProperty();

        Task<List<TypeRoomDto>> GetTypeRoom();

        Task<List<RoomDto>> GetRoom(int idProperty);
        Task<List<PropertyDto>> GetProperty();


    }
}
