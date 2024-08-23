using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Services
{
    public interface IPedidoService
    {
        List<Pedido> GetOrderById(int id);
        int Register(Pedido pedido);
        int Delete(int id);
        int UpdateStatus(Pedido pedido);
        List<Pedido> GetOrders();
    }
}
