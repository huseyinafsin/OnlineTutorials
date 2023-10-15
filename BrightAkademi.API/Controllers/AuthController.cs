using BrightAkademi.Business.Abstract;
using BrightAkademi.Business.Concrete;
using BrightAkademi.Shared.ControllerBases;
using BrightAkademi.Shared.DTOs;
using BrightAkademi.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace BrightAkademi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : CustomControllerBase
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IConfiguration _configuration;

        public AuthController(IUserService userService, IConfiguration configuration, IRoleService roleService)
        {
            _userService = userService;
            _configuration = configuration;
            _roleService = roleService;
        }


        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLogin)  
        {
            var user = await _userService.GetByUsername(userLogin.Username);

            if (!user.IsSucceeded)
            {
                return BadRequest(new CustomResponse { StatusCode=404, Message="User Not Found"});
            }           
            if (user.Data.Password != userLogin.Password)
            {
                return BadRequest(new CustomResponse { StatusCode = 400, Message = "Password incorrect" });
            }
            var userRoles = await _userService.GetUserRoles(user.Data.Id);

            var securityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentals = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Data.Username),                
            };

            userRoles.Data.ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role.Role.Name)));


            var expireDate = DateTime.Now.AddMinutes(30);
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expireDate,
                signingCredentials: credentals);

            return Ok(new
            {
                ExpireDate = expireDate,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Roles = userRoles.Data.Select(x => x.Role.Name),
                Username = user.Data.Username
            }); ;



        }

        [Authorize(Roles="Super Admin")]
        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles()
        {
            var response = await _roleService.GetAllAsync();
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return NotFound();

        }
        
                
        [Authorize(Roles= "Super Admin")]
        [HttpPost("roles")]
        public async Task<IActionResult> CreateRole(RoleDto roleDto)
        {
            var response = await _roleService.CreateAsync(roleDto);
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return BadRequest(response);

        }    
        
        [Authorize(Roles= "Super Admin")]
        [HttpPut("roles")]
        public async Task<IActionResult> UpdateRole(RoleDto roleDto)
        {
            var response = await _roleService.UpdateAsync(roleDto);
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return BadRequest(response);

        } 
        
        [Authorize(Roles= "Super Admin")]
        [HttpDelete("roles")]
        public async Task<IActionResult> DeleteRole(RoleDto roleDto)
        {
            var response = await _roleService.DeleteAsync(roleDto.Id);
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return BadRequest(response);

        }  
        
        [Authorize(Roles= "Super Admin")]
        [HttpGet("roles/{id}")]
        public async Task<IActionResult> GetRole(int id)
        {
            var response = await _roleService.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return BadRequest(response);

        }
        


        }

}
