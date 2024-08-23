using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Services
{
    public interface IVendedorService
    {
        List<Vendedor> GetById(int id);
    }
}
