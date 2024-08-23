using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Services
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> GetUsers();
        IEnumerable<RolUsuario> GetRolesByUserId(int id);
    }
}
