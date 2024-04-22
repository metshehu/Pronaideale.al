using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IUserAgendsRepository
    {
        Task<List<Agends>> GetUserAgends(AppUser user);
        Task<UsersAgends> CreateAsync(UsersAgends usersAgends);
        Task<UsersAgends> DeletUserAgneds(AppUser appUser, int id);
    }
}