using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var users=_context.Users.ToList();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public  IActionResult GetById([FromRoute] int id){
            var users=_context.Users.Find(id);
            if(users == null){
                return NotFound();
            }
            return Ok(users);
        }
        
    }
}