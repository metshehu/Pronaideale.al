using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Users;
using api.Models;

namespace api.Interfaces
{
    public interface IUserRepository
    {
       Task<List<Users>> GetAllAsync();
       Task<Users?> GetByIdAsync(int id );
       Task<Users> CreateAsync(Users usersmodel);

       Task<Users?>UpdateAsync(int id ,UpdateUserDto userDto);

        Task<Users?> DeleteAsync(int id );

    }
}