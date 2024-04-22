using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Propertys;

using api.Models;

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

     public static PropertysDto ToPropertyUIdDto(this Propertys propertyModel){
         return new PropertysDto{
            id=propertyModel.id,
            Name=propertyModel.Name,
            Street=propertyModel.Street,
            City=propertyModel.City,
            AppUsersId=propertyModel.AppUsersId
            };
         }

        
        public static Propertys ToPropertyFromCreateWithId(this CreatePropertyDto propertyModel,string userid){
         return new Propertys{
            Name=propertyModel.Name,
            Street=propertyModel.Street,
            City=propertyModel.City,
            AppUsersId=userid
            };
         }
      public static Propertys ToPropertyFromCreate(this CreatePropertyDto propertyModel){
       return new Propertys{
          Name=propertyModel.Name,
          Street=propertyModel.Street,
          City=propertyModel.City,
          };
      }
    }
}