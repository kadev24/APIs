using Ventas.Domain;

namespace Ventas.WebAPI.Models
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }

        public int? IdCliente { get; set; }

        public int? IdVendedor { get; set; }

        public int? IdCondicionPago { get; set; }

        public string? FechaRequerida { get; set; }

        public string? FechaPedido { get; set; }

        public decimal? TotalDescuento { get; set; }

        public decimal? Total { get; set; }

        public string? EstadoPedido { get; set; }

        public string? UsuarioRegistro { get; set; }

        public string? FechaRegistro { get; set; }

        public string? UsuarioModifica { get; set; }

        public string? FechaModifica { get; set; }

        public virtual ICollection<PedidoLineaModel> PedidoLineas { get; set; } = new List<PedidoLineaModel>();
    }
}
