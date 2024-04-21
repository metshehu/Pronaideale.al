using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Users;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context){
            _context=context;
        }

        public async Task<Users> CreateAsync(Users usersmodel)
        {
            await _context.Users.AddAsync(usersmodel);
            await _context.SaveChangesAsync();
            return usersmodel;
        }

        public async Task<Users?> DeleteAsync(int id)
        {
            var userModel=await _context.Users.FirstOrDefaultAsync(i=> i.id==id);
            if(userModel==null){
                return null;
            }
            _context.Users.Remove(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }

        public async Task<List<Users>> GetAllAsync()
        {
            return await  _context.Users.Include(p=> p.Propertys).ToListAsync(); 
        }

        public async Task<Users?> GetByIdAsync(int id)
        {
            return await _context.Users.Include(p=>p.Propertys).FirstOrDefaultAsync(x=> x.id==id);
        }

        public async Task<Users?> UpdateAsync(int id, UpdateUserDto userDto)
        {
            var exsitinguser= await _context.Users.FirstOrDefaultAsync(i=> i.id == id );
            if(exsitinguser == null){
                return null;
            }
            exsitinguser.Name=userDto.Name;
            exsitinguser.Lastname=userDto.Lastname;
            exsitinguser.Phone=userDto.Phone;
            exsitinguser.Adress=userDto.Adress;
            await _context.SaveChangesAsync();
            return exsitinguser;
        }
    }
}