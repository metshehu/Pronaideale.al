using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Users;
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
        public UsersController(ApplicationDBContext context)
        {
         _context=context;   
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users =await _context.Users.ToListAsync();
            var userdto=users.Select(s=> s.ToUsersDto());
            return Ok(users);
        }
        [HttpGet]
        [Route("{id}")]
        public  IActionResult GetById([FromRoute] int id){
            var users=_context.Users.Find(id);
            if(users == null){
                return NotFound();
            }
            return Ok(users);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequestDto userdto){
            var userModel=userdto.ToUsersFromCreateDto();
            _context.Users.Add(userModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById),new {id=userModel.id},userModel.ToUsersDto());
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id ,[FromBody] UpdateUserDto UpdateDto){
            var usersModel=_context.Users.FirstOrDefault(i=> i.id == id );
            if(usersModel == null){
                return NotFound();
            }
            usersModel.Name=UpdateDto.Name;
            usersModel.Lastname=UpdateDto.Lastname;
            usersModel.Phone=UpdateDto.Phone;
            usersModel.Adress=UpdateDto.Adress;
            _context.SaveChanges();
            return Ok(usersModel);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delet([FromRoute] int id){
            var userModel=_context.Users.FirstOrDefault(i=> i.id==id);
            if(userModel==null){
                return NotFound();
            }
            _context.Users.Remove(userModel);
            _context.SaveChanges();
            return NoContent();
        }

    }
}