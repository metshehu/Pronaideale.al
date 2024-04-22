using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Agends;
using api.Models;
using Mysqlx.Crud;

namespace api.Interfaces
{
    public interface IAgendsRepository
    {
        Task<List<Agends>> GetAllAsync();
        Task<Agends?> GetByIdAsync(int id);

        Task<Agends> CreateAsync(Agends agendsmodel);

        Task<Agends?> UpdateAsync(int id,UpdateAgendsDto agendsDto);

        Task<Agends?> DeletAsync(int id);
    }
}