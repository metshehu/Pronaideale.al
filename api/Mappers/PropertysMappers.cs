using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Propertys;

using api.Models;
using Org.BouncyCastle.Bcpg;

namespace api.Mappers
{
    public static class PropertysMappers
    {
     public static PropertysDto ToPropertyDto(this Propertys propertyModel){
         return new PropertysDto{
            id=propertyModel.id,
            Name=propertyModel.Name,
            Street=propertyModel.Street,
            City=propertyModel.City
            };
         }

        
        public static Propertys ToPropertyFromCreateDto(this CreatePropertysRequestDto propertyDto, int UserId){
            return new Propertys{
                Name= propertyDto.Name,
                Street=propertyDto.Street,
                City=propertyDto.City,
                UsersId=UserId,
            };
        }
    }
}