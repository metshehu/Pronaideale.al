using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Companys;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CompanysRepository : ICompanyRepository
    {
       
        private readonly ApplicationDBContext _context;
        public CompanysRepository(ApplicationDBContext contex){
            _context=contex;
        }
        public async Task<Companys> CreateAsync(Companys compnaymodel)
        {
            await _context.Companys.AddAsync(compnaymodel);
            await _context.SaveChangesAsync();
            return compnaymodel;

        }


        public async Task<Companys?> DeletAsync(int id)
        {
            var companymodel= await _context.Companys.FirstOrDefaultAsync(x=>x.id==id);
            if(companymodel == null){
                return null;
            }
            _context.Companys.Remove(companymodel);
            await _context.SaveChangesAsync();
            return companymodel; 
        }

        public async Task<List<Companys>> GetAllAsync()
        {
           return await _context.Companys.Include(a=>a.Agends).ToListAsync();
        }

        public async Task<Companys?> GetByIdAsync(int id)
        {
            var companymodel=await _context.Companys.FirstOrDefaultAsync(x=>x.id==id);
            if(companymodel==null){
                return null;
            }
            return companymodel;

        }

        public async Task<Companys?> UpdateAsync(int id, UpdateCompanyDto compnayDto)
        {
            var companymodel=await _context.Companys.FirstOrDefaultAsync(x=>x.id==id);
            if(companymodel==null){
                return null;
            }
            companymodel.Name=compnayDto.Name;
            
            companymodel.Adress=compnayDto.Adress;
            companymodel.Phone=compnayDto.Phone;
            companymodel.Rating=compnayDto.Rating;
            await _context.SaveChangesAsync();
            return companymodel;
        }
    }
}