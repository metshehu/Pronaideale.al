using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Propertys;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore.Metadata;
using api.Extensions;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Account;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace api.Controllers
{
    [Route("api/Propertys")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
         private readonly ApplicationDBContext _context;
        private readonly IPropertyRepositroy _ProeprtyRepo;
        private readonly UserManager<AppUser> _userManger;
        public PropertyController(ApplicationDBContext context,IPropertyRepositroy proeprtyrepo,UserManager<AppUser> userManager)
        {
        _context=context;   
        _ProeprtyRepo=proeprtyrepo;
        _userManger=userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var propertys= await _ProeprtyRepo.GetAllAsync();
            var proeprtydto= propertys.Select(x=> x.ToPropertyDto());
            return Ok(proeprtydto);
        }
        [HttpGet("{id}")]
        public  async Task<IActionResult> GetById([FromRoute] int id){
            var property=await _ProeprtyRepo.GetByIdAsync(id);
            if(property == null){
                return NotFound();
            }
            return Ok(property);
        }
        [HttpGet("GetByProptysBytoken")]
        [Authorize]
        public async Task<IActionResult> GetUesrsProeptys(){
            var username = User.GetUsername();
            var user= await _userManger.FindByNameAsync(username);

            var userprops =  _context.Propertys.Any(x=>x.AppUsersId==user.Id);
            return Ok(userprops);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePropertyDto propertydto){
            var PropertysModel=propertydto.ToPropertyFromCreate();
            await _ProeprtyRepo.CreateAsync(PropertysModel);
            return CreatedAtAction(nameof(GetById),new {id=PropertysModel.id},PropertysModel.ToPropertyDto());
        }
        [Authorize]
        [HttpPost("CreatePropertyByUser")]
        public async Task<IActionResult> Create([FromRoute] string id,[FromBody] CreatePropertyDto propertydto){
            var PropertysModel=propertydto.ToPropertyFromCreateWithId(id);
            
            await _ProeprtyRepo.CreateAsync(PropertysModel);

            return CreatedAtAction(nameof(GetById),new {id=PropertysModel.id},PropertysModel.ToPropertyDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id ,[FromBody] UpdatePropertysDto propertysDto){
            var proeprtyModel=await _ProeprtyRepo.UpdateAsync(id,propertysDto);
            if(proeprtyModel==null){return NotFound();}
            return Ok(proeprtyModel);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delet([FromRoute] int id ){
            var propertyModel= await _ProeprtyRepo.DeletAsync(id);
            if(propertyModel==null){
                return NotFound();
            }
            return NoContent();
        }
        }

}
