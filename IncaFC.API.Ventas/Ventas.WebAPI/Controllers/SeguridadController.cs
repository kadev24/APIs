using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ventas.Domain;
using Ventas.Domain.Services;

namespace Ventas.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguridadController : ControllerBase
    {
        private IUsuarioService _usuarioService;
        public SeguridadController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [Authorize(Roles = "admin")]
        [HttpGet("GetUsers")]
        public IEnumerable<Usuario> GetUsers()
        {
            return _usuarioService.GetUsers();
        }

        [Authorize(Roles = "admin")]
        [HttpGet("GetRolesByUser/userId")]
        public IEnumerable<RolUsuario> GetRolesByUser(int userId)
        {
            return _usuarioService.GetRolesByUserId(userId);
        }
    }
}
