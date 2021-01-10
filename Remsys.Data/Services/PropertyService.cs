using Remsys.Domain.Dtos;
using Remsys.Data.Helpers;
using Remsys.Data.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Remsys.Data.Services
{
    public class PropertyService : BaseService, IPropertyService
    {
        public async Task<string> DeleteProperty(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblInmueble, new object[] { id })) ;
        }

        public async Task<string> DeleteRoom(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTblHabitacion, new object[] { id }));
        }

        public async Task<string> DeleteTypeOperation(int id)
        {
          return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTipoOperacionInmueble, new object[] { id }));
        }

        public async Task<string> DeleteTypeProperty(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTipoPropiedad, new object[] { id }));
        }

        public async Task<string> DeleteTypeRoom(int id)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.DeleteInTblTipoHabitacion, new object[] { id }));
        }

        public async Task<List<PropertyDto>> GetProperty()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.JoinTblInmueble));
            List<PropertyDto> dtos = new List<PropertyDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new PropertyDto
                {
                    Id = item.Field<int>(0),
                    IdEstateAgent = item.Field<int>(1),
                    IdPropertyType = item.Field<int>(2),
                    PropertyTypeDto = new PropertyTypeDto { 
                    Id = item.Field<int>(2),
                    Name = item.Field<string>(3),
                    },
                    IdProperyOperationType = item.Field<int>(4),
                    ProperyOperationTypeDto = new ProperyOperationTypeDto { 
                    Id = item.Field<int>(4),
                    Name = item.Field<string>(5),
                    },
                    IdAttorney = item.Field<int>(6),
                    IdRoom = item.Field<int>(7),
                    PropertyValue = item.Field<decimal>(8),
                     Description =  item.Field<string>(9),
                     Rate = item.Field<int>(10),
                     Image = item.Field<string>(11),

                });
            }
            return dtos;
        }

        public async Task<List<RoomDto>> GetRoom(int idProperty)
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarHabitacionPorInmueble, new object[] { idProperty }));
            List<RoomDto> dtos = new List<RoomDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new RoomDto
                {
                    Id = item.Field<int>(0),
                    IdPropery = item.Field<int>(1),
                    IdTypeRoom = item.Field<int>(2),
                    TypeRoom = new TypeRoomDto { 
                    Id= item.Field<int>(2),
                    Name =  item.Field<string>(3),
                    },
                    Quantity = item.Field<int>(4),
                });
            }
            return dtos;
        }

        public async Task<List<ProperyOperationTypeDto>> GetTypeOperation()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTipoOperacion));
            List<ProperyOperationTypeDto> dtos = new List<ProperyOperationTypeDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new ProperyOperationTypeDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),

                });
            }
            return dtos;
        }

        public async Task<List<PropertyTypeDto>> GetTypeProperty()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTipoPropiedad));
            List<PropertyTypeDto> dtos = new List<PropertyTypeDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new PropertyTypeDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),

                });
            }
            return dtos;
        }

        public  async  Task<List<TypeRoomDto>> GetTypeRoom()
        {
            var datas = await Task.FromResult(Getdata(StoreProcedureConstant.MostrarTipoHabitacion));
            List<TypeRoomDto> dtos = new List<TypeRoomDto>();
            DataTable dt = datas.Tables["Table"];
            foreach (DataRow item in dt.Rows)
            {
                dtos.Add(new TypeRoomDto
                {
                    Id = item.Field<int>(0),
                    Name = item.Field<string>(1),

                });
            }
            return dtos;
        }

        public async Task<string> SaveProperty(PropertyDto propertyDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblInmueble, new object[] { propertyDto.IdEstateAgent, propertyDto.IdPropertyType, propertyDto.IdProperyOperationType,
                propertyDto.IdAttorney, propertyDto.IdAddress, propertyDto.PropertyValue, propertyDto.QuantityMeters, propertyDto.Description, propertyDto.Estado, propertyDto.Rate, propertyDto.Image }));
        }

        public async Task<string> SaveRoom(RoomDto roomDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblHabitacion, new object[] { roomDto.IdTypeRoom, roomDto.Property, roomDto.Quantity }));
        }

        public async Task<string> SaveTypeOperation(ProperyOperationTypeDto properyOperationTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblTipoHabitacion, new object[] {  properyOperationTypeDto.Name }));
        }

        public async Task<string> SaveTypeProperty(PropertyTypeDto propertyTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblTipoPropiedad, new object[] { propertyTypeDto.Name }));
        }

        public async Task<string> SaveTypeRoom(TypeRoomDto typeRoomDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.InsertInTblTipoOperacionInmueble, new object[] {  typeRoomDto.Name }));
        }

        public async Task<string> UpdateProperty(PropertyDto propertyDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateInTblInmueble, new object[] {propertyDto.Id, propertyDto.IdEstateAgent, propertyDto.IdPropertyType, propertyDto.IdProperyOperationType,
                propertyDto.IdAttorney, propertyDto.IdAddress, propertyDto.PropertyValue, propertyDto.QuantityMeters, propertyDto.Description, propertyDto.Estado, propertyDto.Rate, propertyDto.Image }));
        }

        public async Task<string> UpdateRoom(RoomDto roomDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateInTblHabitacion, new object[] { roomDto.Id,roomDto.IdTypeRoom, roomDto.Property, roomDto.Quantity }));
        }

        public async Task<string> UpdateTypeOperation(ProperyOperationTypeDto properyOperationTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateInTblTipoOperacionInmueble, new object[] { properyOperationTypeDto.Id, properyOperationTypeDto.Name }));
        }

        public async Task<string> UpdateTypeProperty(PropertyTypeDto propertyTypeDto)
        {
            return await Task.FromResult(CommandGrud(StoreProcedureConstant.UpdateInTblTipoPropiedad, new object[] { propertyTypeDto.Id, propertyTypeDto.Name }));
        }


    }
}
