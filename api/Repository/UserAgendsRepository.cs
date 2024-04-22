using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class UserAgendsRepository : IUserAgendsRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        private readonly IAgendsRepository _agendsRepository;
        public UserAgendsRepository(ApplicationDBContext context , UserManager<AppUser> userManager ,IAgendsRepository agendsRepository){
            _context=context;
            _userManager=userManager;
            _agendsRepository=agendsRepository;
        }

        public async Task<UsersAgends> CreateAsync(UsersAgends usersAgends)
        {
            await _context.UsersAgends.AddAsync(usersAgends);
            await _context.SaveChangesAsync();
            return usersAgends;
        }

        public async Task<UsersAgends> DeletUserAgneds(AppUser appUser, int id)
        {
            var userAgendsModel= await _context.UsersAgends.FirstOrDefaultAsync(x => x.AppUsersId == appUser.Id && x.AgendsId == id);

            if (userAgendsModel == null)
            {
                return null;
            }

            _context.UsersAgends.Remove(userAgendsModel);
            await _context.SaveChangesAsync();
            return userAgendsModel;
        }

        public async Task<List<Agends>> GetUserAgends(AppUser user)
        {
            return await _context.UsersAgends.Where(u=>u.AppUsersId == user.Id)
             .Select(agend => new Agends
            {
                id = agend.AgendsId,
                Phone = agend.Agends.Phone,
                Deals = agend.Agends.Deals,
                CompanysId = agend.Agends.CompanysId,
                Description = agend.Agends.Description
            }).ToListAsync();
        }
        }
    }
