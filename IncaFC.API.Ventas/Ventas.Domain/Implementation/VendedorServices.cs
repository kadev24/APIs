using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Services;

namespace Ventas.Domain.Implementation
{
    public class VendedorServices : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;
        public VendedorServices(IVendedorRepository vendedorRepository)
        {
                _vendedorRepository = vendedorRepository;
        }

        public List<Vendedor> GetById(int id)
        {
            return _vendedorRepository.GetAll().ToList();
        }
    }
}
