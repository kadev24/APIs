using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ventas.Domain;
using Ventas.Domain.Services;
using Ventas.WebAPI.Models;

namespace Ventas.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IConfiguration _config;
        private ILoginService _loginService;
        public AuthController(IConfiguration config, ILoginService loginService)
        {
            _config = config;
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginModel loginRequest)
        {
            //your logic for login process
            //If login usrename and password are correct then proceed to generate token

            var userLogin = _loginService.Login(new Usuario { Usuario1 = loginRequest.User, Clave = loginRequest.Password });

            if (userLogin.Usuario1 != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:SecretKey"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var rol = userLogin.RolUsuarios.First().Rol;

                var claims = new[] {
                    new Claim(ClaimTypes.NameIdentifier, userLogin.Usuario1),
                    new Claim(ClaimTypes.Email, userLogin.Correo),
                    new Claim(ClaimTypes.Role, rol),
                };

                var Sectoken = new JwtSecurityToken(_config["JwtSettings:Issuer"],
                    _config["JwtSettings:Issuer"],
                  claims,
                  expires: DateTime.Now.AddMinutes(120),
                  signingCredentials: credentials);

                var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

                return Ok(token);
            }

            return Unauthorized(new { StatusCode = 401, Message = "Credenciales inválidas" });
            
        }
    }
}
