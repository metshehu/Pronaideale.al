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
using api.Dtos.Propertys;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

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
﻿public async Task<Propertys?> DeletAsync(int id)
        {
            var proerptyModel=await _context.Propertys.FirstOrDefaultAsync(x=> x.id==id);
            if (proerptyModel ==null){
                return null;
            }
            _context.Propertys.Remove(proerptyModel);
            await _context.SaveChangesAsync();
            return proerptyModel;
        }

        public async Task<List<Propertys>> GetAllAsync()
        {
            return await _context.Propertys.ToListAsync(); 
        }

        public async Task<Propertys?> GetByIdAsync(int id)
        {
            return await _context.Propertys.FindAsync(id);
        }

        public async Task<Propertys?> UpdateAsync(int id, UpdatePropertysDto propertysDto)
        {
            var preoprtymodel= await _context.Propertys.FirstOrDefaultAsync(x=>x.id==id);

            if(preoprtymodel == null){
                return null;
            }
            preoprtymodel.Name=propertysDto.Name;
            preoprtymodel.City=propertysDto.City;
            preoprtymodel.Street=propertysDto.Street;
            await _context.SaveChangesAsync();

            return preoprtymodel;
        }
}
}
