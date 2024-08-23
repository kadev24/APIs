using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Services;

namespace Ventas.Domain.Implementation
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public int Delete(int id)
        {
            var pedido = _pedidoRepository.FindOne(c => c.IdPedido == id);
            pedido.EstadoPedido = "X";
            pedido.FechaModifica = DateTime.Now;
            _pedidoRepository.Update(pedido);
            
            return 0;
        }

        public List<Pedido> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> GetOrders()
        {
            return _pedidoRepository.GetAll().ToList();
        }

        public int Register(Pedido pedido)
        {
            _pedidoRepository.Add(pedido);
            _pedidoRepository.SaveChanges();
            return 0;
        }

        public int UpdateStatus(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
