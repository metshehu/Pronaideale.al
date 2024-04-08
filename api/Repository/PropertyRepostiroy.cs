using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;

using api.Dtos.Users;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api.Repository
{
    public class PropertyRepostiroy : IPropertyRepositroy
    {
        private readonly ApplicationDBContext _context;

        public PropertyRepostiroy(ApplicationDBContext context){
            _context=context;
        }

        public async Task<Propertys> CreateAsync(Propertys usersmodel)
        {
            await _context.Propertys.AddAsync(usersmodel);
            await _context.SaveChangesAsync();
            return usersmodel;            
        }

        public async Task<List<Propertys>> GetAllAsync()
        {
            return await _context.Propertys.ToListAsync(); 
        }

        public async Task<Propertys?> GetByIdAsync(int id)
        {
            return await _context.Propertys.FindAsync(id);
        }
    }
}