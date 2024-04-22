using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Account;
using api.Extensions;
using api.Interfaces;
using api.Models;
using Azure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Iana;

namespace api.Controllers
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController :ControllerBase
    {
    private readonly UserManager<AppUser> _userManager;
    private  readonly ITokenService _tokenService;
    private  readonly SignInManager<AppUser> _signInManager;
    public AccountController(UserManager<AppUser> userManager , ITokenService tokenService, SignInManager<AppUser> signInManager){
        _userManager=userManager;
        _tokenService=tokenService;
        _signInManager=signInManager;
    }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email
                };


                var createdUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if (createdUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                    if (roleResult.Succeeded)
                    {
                        return Ok(
                            new NewUserDto{
                                UserName=appUser.UserName,
                                Email=appUser.Email,
                                Token=_tokenService.CreateToken(appUser)
                            }
                        );
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createdUser.Errors);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto){
        if(!ModelState.IsValid){
            return BadRequest(ModelState);
        }
        var user = await _userManager.Users.FirstOrDefaultAsync(x=> x.UserName == loginDto.Username.ToLower());

        if(user ==null ) {return Unauthorized("invalid Username!");}
        var result= await _signInManager.CheckPasswordSignInAsync(user,loginDto.Password,false);
        if(!result.Succeeded) return Unauthorized("Username not found and or password incorect");
        return Ok(
            new NewUserDto{
                UserName=user.UserName,
                Email=user.Email,
                Token=_tokenService.CreateToken(user)
            }
        );
    }
    [HttpGet("token")]
    [Authorize]
    public async Task<IActionResult> GetToken(){
        var username = User.GetUsername();
        var user= await _userManager.FindByNameAsync(username);
        if(user == null){return NotFound();}
        var token = _tokenService.CreateToken(user);
        
        return Ok(new NewUserDto{
                Token=token
            });
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> Update([FromBody] UpdateUserDto Userinfo){
        var username = User.GetUsername(); 
        var user = await _userManager.FindByNameAsync(username);
        if(user == null){
            return NotFound();
        }
        await _userManager.RemovePasswordAsync(user);
        await _userManager.AddPasswordAsync(user,Userinfo.Password);
        return Ok(user);
    }
    [HttpDelete]
    [Authorize]
    public async Task<IActionResult> Delet(){
        var user= User.GetUsername();
        var appuser= await _userManager.FindByNameAsync(user);
        if(appuser == null){return NotFound();}
        await _userManager.DeleteAsync(appuser);
        return NoContent();
    }
}
}