using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Extensions;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/UserAgneds")]
    [ApiController]
    public class UsersAgendsController :ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<AppUser> _usermanger;
        private readonly IAgendsRepository _agendsRepository;
        private readonly IUserAgendsRepository _userAgendsRepository;
        public UsersAgendsController (ApplicationDBContext context,IAgendsRepository agendsRepository,UserManager<AppUser> userManager,IUserAgendsRepository userAgendsRepository){
            _context=context;
            _agendsRepository=agendsRepository;
            _usermanger=userManager;
            _userAgendsRepository=userAgendsRepository;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAgends(){
            var username= User.GetUsername();
            var user = await _usermanger.FindByNameAsync(username);
            
            var userAgends= await _userAgendsRepository.GetUserAgends(user);
            return Ok(userAgends);
        }  
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAgends(int id){
            var username= User.GetUsername();
            var user = await _usermanger.FindByNameAsync(username);
            var agend= await _agendsRepository.GetByIdAsync(id);
            if(agend == null){return NotFound();}

            var useragends= await _userAgendsRepository.GetUserAgends(user);
            if(useragends.Any(x=>x.id == id)) return BadRequest("this agends cant be on the same user more then 2 times");
            var userAgendsModel = new UsersAgends {
                AppUsersId=user.Id,
                AgendsId=agend.id
            };

            await _userAgendsRepository.CreateAsync(userAgendsModel);
            return Created();
        } 
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeletAgends(int id){
            var username= User.GetUsername();
            var user = await _usermanger.FindByNameAsync(username);
            
            
            var userAgends = await _userAgendsRepository.GetUserAgends(user);

            var useragends= await _userAgendsRepository.GetUserAgends(user);
            var fillteragends= useragends.Where(s => s.id== id );
            
            if(fillteragends.Count()==1){
                await _userAgendsRepository.DeletUserAgneds(user, id);
            }else{
                return BadRequest();
            }
            return Ok();
        }   
    }
}