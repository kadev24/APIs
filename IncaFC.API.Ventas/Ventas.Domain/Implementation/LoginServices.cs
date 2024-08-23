using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Services;

namespace Ventas.Domain.Implementation
{
    public class LoginServices : ILoginService
    {
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IUsuarioRolRepository _UsuarioRolRepository;
        public LoginServices(IUsuarioRepository UsuarioRepository, IUsuarioRolRepository UsuarioRolRepository)
        {
            _UsuarioRepository = UsuarioRepository;
            _UsuarioRolRepository = UsuarioRolRepository;
        }

        public Usuario Login(Usuario usuario)
        {
            Usuario user = new Usuario();
            var result = _UsuarioRepository.Find(u => u.Usuario1 == usuario.Usuario1 && u.Clave == usuario.Clave);

            if (result.Count() > 0)
            {
                user = result.First();
                user.RolUsuarios = _UsuarioRolRepository.Find(m => m.IdUsuario == user.IdUsuario).ToList();
            }

            return user;
        }
    }
}
