using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Companys;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api.Controllers
{
    [Route("api/Companys")]
    [ApiController]

    public class CompanyController:ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ApplicationDBContext context,ICompanyRepository companyRepository)

        {
        _context=context;   
        _companyRepository=companyRepository;
        }
    [HttpGet]
    public async Task<IActionResult> GetAll(){
        var agends=await _companyRepository.GetAllAsync();
        return Ok(agends);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute]int id){
        var company= await _companyRepository.GetByIdAsync(id);
        if(company ==null){
            return NotFound();
        }
        return Ok(company);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCompanydto companydto){
        var Companymodle=companydto.ToCompanyDtoCreate();
        await _companyRepository.CreateAsync(Companymodle);
            return CreatedAtAction(nameof(GetById),new {id=Companymodle.id},Companymodle.ToCompanyDto());
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute]int id ,[FromBody] UpdateCompanyDto companydto){
        var companymodel= await _companyRepository.UpdateAsync(id,companydto);       
        if(companymodel == null){
            return NotFound();
        }
        return Ok(companymodel);         
            }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delet([FromRoute]int id){
        var companymodel= await _companyRepository.DeletAsync(id);       
        if(companymodel == null){
            return NotFound();
        }
        return NoContent(); 
            }
}
}