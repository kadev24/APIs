using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Services;

namespace Ventas.Domain.Implementation
{
    public class UsuarioServices : IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IUsuarioRolRepository _UsuarioRolRepository;
        public UsuarioServices(IUsuarioRepository UsuarioRepository, IUsuarioRolRepository UsuarioRolRepository)
        {
            _UsuarioRepository = UsuarioRepository;
            _UsuarioRolRepository = UsuarioRolRepository;
        }

        public IEnumerable<RolUsuario> GetRolesByUserId(int id)
        {
            return _UsuarioRolRepository.Find(m=> m.IdUsuario == id);
        }

        public IEnumerable<Usuario> GetUsers()
        {
            return _UsuarioRepository.GetAll();
        }
    }
}
