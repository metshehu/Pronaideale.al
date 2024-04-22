using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Agends;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{   
    
    public class AgendsRepository : IAgendsRepository
    {
    private readonly ApplicationDBContext _context;
    public AgendsRepository(ApplicationDBContext contex){
            _context=contex;
        }

        public async Task<Agends> CreateAsync(Agends agendsmodel)
        {
            await _context.Agends.AddAsync(agendsmodel);
            await _context.SaveChangesAsync();
            return agendsmodel;
        }

        public async Task<Agends?> DeletAsync(int id)
        {
            var agend= await _context.Agends.FirstOrDefaultAsync(x=>x.id==id);
            if(agend ==null){
                return null;
            }
            _context.Agends.Remove(agend);
            await _context.SaveChangesAsync();
            return agend;
        }

        public async Task<List<Agends>> GetAllAsync()
        {
           return await _context.Agends.ToListAsync();
        }

        public async Task<Agends?> GetByIdAsync(int id)
        {
            return await _context.Agends.FirstOrDefaultAsync(x=> x.id==id);
        }

        public async Task<Agends?> UpdateAsync(int id, UpdateAgendsDto agendsDto)
        {
            var agend =await _context.Agends.FirstOrDefaultAsync(x=> x.id==id);
            if(agend == null){return null;}
            agend.CompanysId=agendsDto.CompanysId;
            agend.Phone=agendsDto.Phone; 
            agend.YoE=agendsDto.YoE;
            agend.Deals=agendsDto.Deals;
            await _context.SaveChangesAsync();
            return agend; 
        }
    }
}