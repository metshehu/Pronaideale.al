using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api.Interfaces
{
    public interface IPropertyRepositroy
    {
        Task<List<Propertys>> GetAllAsync();
       Task<Propertys?> GetByIdAsync(int id );
       Task<Propertys> CreateAsync(Propertys usersmodel);
    }
}