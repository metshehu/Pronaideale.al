using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Propertys;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [Route("api/Propertys")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
         private readonly ApplicationDBContext _context;
         public PropertyController(ApplicationDBContext context)
        {
         _context=context;   
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var propertys=_context.Propertys.ToList();
            return Ok(propertys);
        }
        [HttpGet("{id}")]
        public  IActionResult GetById([FromRoute] int id){
            var property=_context.Propertys.Find(id);
            if(property == null){
                return NotFound();
            }
            return Ok(property);
        }
        [HttpPost]
        public IActionResult Create([FromBody] CreatePropertysRequestDto propertydto){
             var PropertysModel=propertydto.ToPropertyFromCreateDto();
            _context.Propertys.Add(PropertysModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById),new {id=PropertysModel.id},PropertysModel.ToPropertyDto());
        }

        }

}
