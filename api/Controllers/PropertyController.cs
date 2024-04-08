using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Propertys;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore.Metadata;


namespace api.Controllers
{
    [Route("api/Propertys")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
         private readonly ApplicationDBContext _context;
        
        private readonly IPropertyRepositroy _ProeprtyRepo;
        public PropertyController(ApplicationDBContext context,IPropertyRepositroy proeprtyrepo)
        {
         _context=context;   
         _ProeprtyRepo=proeprtyrepo;
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
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePropertysRequestDto propertydto){
            var PropertysModel=propertydto.ToPropertyFromCreateDto();
            await _ProeprtyRepo.CreateAsync(PropertysModel);
            return CreatedAtAction(nameof(GetById),new {id=PropertysModel.id},PropertysModel.ToPropertyDto());
        }

        }

}
