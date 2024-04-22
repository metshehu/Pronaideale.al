using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Agends;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers 
{
    [Route("api/Agends")]
    [ApiController]
    public class AgendsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IAgendsRepository _agendRepository;

        public AgendsController(ApplicationDBContext context,IAgendsRepository agendsrep)
        {
        _context=context;   
        _agendRepository=agendsrep;
        }
    [HttpGet]
    public async Task<IActionResult> GetAll(){
        var agends=await _agendRepository.GetAllAsync();
        var agendsDtos=agends.Select(x=>x.ToAgendsDto());
        return Ok(agendsDtos);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id ){
        var agend =await _agendRepository.GetByIdAsync(id);
        
        if(agend == null){
            return NotFound();
        }
        return Ok(agend);
        
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAgendsDto agetDto){
        var agend=agetDto.ToAgendsFromCreate();
        var agendsDto=await _agendRepository.CreateAsync(agend);
        return CreatedAtAction(nameof(GetById),new {id=agend.id},agend.ToAgendsDto());
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id , [FromBody] UpdateAgendsDto agedDto){
    var  updateModel = await _agendRepository.UpdateAsync(id,agedDto);
    if(updateModel == null){return NotFound();}
    return Ok(updateModel);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delet(int id){
        var agends=await _agendRepository.DeletAsync(id);
        if(agends == null){return NotFound();}
        return NoContent();
    }
    }

}