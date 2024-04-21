using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Users;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IUserRepository _userRepo;
        public UsersController(ApplicationDBContext context, IUserRepository userRepo)
        {
         _context=context;   
         _userRepo=userRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users =await _userRepo.GetAllAsync(); 
            var userdto=users.Select(s=> s.ToUsersDto());
            return Ok(userdto);
        }
        [HttpGet]
        [Route("{id}")]
        public  async Task<IActionResult> GetById([FromRoute] int id){
            var users=await _userRepo.GetByIdAsync(id);
            if(users == null){
                return NotFound();
            }
            return Ok(users);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequestDto userdto){
            var userModel=userdto.ToUsersFromCreateDto();
            await _userRepo.CreateAsync(userModel);
            return CreatedAtAction(nameof(GetById),new {id=userModel.id},userModel.ToUsersDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id ,[FromBody] UpdateUserDto UpdateDto){
            var usersModel=await _userRepo.UpdateAsync(id,UpdateDto);
            if(usersModel == null){
                return NotFound();
            }
            return Ok(usersModel);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delet([FromRoute] int id){
            var userModel=await _userRepo.DeleteAsync(id);
            if(userModel==null){
                return NotFound();
            }
            return NoContent();
        }

    }
}