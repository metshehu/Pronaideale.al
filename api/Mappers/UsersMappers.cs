using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Users;
using api.Models;


namespace api.Mappers
{
    public static class UsersMappers
    {
        public static UsersDto ToUsersDto(this Users userModel){
         return new UsersDto{
            id=userModel.id,
            Name=userModel.Name,
            Lastname=userModel.Lastname,
         };

        }
        public static Users ToUsersFromCreateDto(this CreateUserRequestDto userDto){
            return new Users{
                Name= userDto.Name,
                Lastname=userDto.Lastname,
                Adress=userDto.Adress,
                Phone=userDto.Phone
            };
        }
    }
}