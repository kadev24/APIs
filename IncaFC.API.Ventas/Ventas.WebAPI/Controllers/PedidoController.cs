using log4net.Config;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Ventas.Data.Repositories;
using Ventas.Domain;
using Ventas.Domain.Implementation;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Services;
using Ventas.WebAPI.Models;

namespace Ventas.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PedidoController : ControllerBase
    {


        private IPedidoService _pedidoService;
        private ILogger1 _logger;
        public PedidoController(IPedidoService pedidoService, ILogger1 logger)
        {
            _pedidoService = pedidoService;
            _logger = logger;
        }

        [Authorize]
        [HttpPost("DeleteOrder")]
        public IActionResult DeleteOrder(Pedido pedido)
        {
            try
            {
                var result = new OperationResult();
                _pedidoService.Delete(pedido.IdPedido);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "admin,user")]
        [HttpGet("GetOrders")]
        public IEnumerable<Pedido> GetOrders()
        {
            return _pedidoService.GetOrders();
        }

        [Authorize(Roles = "admin,user")]
        [HttpPost("InsertOrder")]
        public IActionResult InsertOrder([FromBody] PedidoModel pedido)
        {
            try
            {
                DateTime? fechaReq = DateTime.TryParse(pedido.FechaRequerida, out DateTime date) ? date: null;


                Pedido pedido1 = new Pedido();
                pedido1.IdCliente = pedido.IdCliente;
                pedido1.IdVendedor = pedido.IdVendedor;
                pedido1.IdCondicionPago = pedido.IdCondicionPago;
                pedido1.FechaRequerida = fechaReq.HasValue ? DateOnly.FromDateTime(fechaReq.Value) : null;
                pedido1.FechaPedido = DateTime.Now;
                pedido1.TotalDescuento = pedido.TotalDescuento;
                pedido1.Total = pedido.Total;
                pedido1.EstadoPedido = pedido.EstadoPedido;
                pedido1.UsuarioRegistro = pedido.UsuarioRegistro;
                pedido1.FechaRegistro = DateTime.Now;
                pedido1.UsuarioModifica = pedido.UsuarioModifica;
                pedido1.FechaModifica = null;

                PedidoLinea pedidoLinea;
                foreach (var linea in pedido.PedidoLineas)
                {
                    pedidoLinea = new PedidoLinea();
                    pedidoLinea.IdArticulo = linea.IdArticulo;
                    pedidoLinea.IdAlmacen = linea.IdAlmacen;
                    pedidoLinea.PrecioLista = linea.PrecioLista;
                    pedidoLinea.Cantidad = linea.Cantidad;
                    pedidoLinea.Moneda = linea.Moneda;
                    pedidoLinea.ImpuestoIgv = linea.ImpuestoIgv;
                    pedidoLinea.Descuento = linea.Descuento;
                    pedidoLinea.Subtotal = linea.Subtotal;
                    pedidoLinea.UsuarioRegistro = linea.UsuarioRegistro;
                    pedidoLinea.FechaRegistro = DateTime.Now;
                    pedidoLinea.UsuarioModifica = linea.UsuarioModifica;
                    pedidoLinea.FechaModifica = null;

                    pedido1.PedidoLineas.Add(pedidoLinea);
                }

                var result = new OperationResult();
                var code = _pedidoService.Register(pedido1);

                if (code == 0)
                {
                    result.StatusCode = 100;
                    result.Message = "Pedido registrado correctamente";
                }
                else
                {
                    result.StatusCode = 0;
                    result.Message = "No se puedo registrar el pedido corectamente";
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                return BadRequest(ex.Message);
            }
        }
    }
}
