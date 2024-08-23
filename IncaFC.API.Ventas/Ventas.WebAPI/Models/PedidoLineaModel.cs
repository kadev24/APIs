using Ventas.Domain;

namespace Ventas.WebAPI.Models
{
    public class PedidoLineaModel
    {
        public int IdPedidoLinea { get; set; }

        public int? IdPedido { get; set; }

        public int? IdArticulo { get; set; }

        public int? IdAlmacen { get; set; }

        public decimal? PrecioLista { get; set; }

        public int? Cantidad { get; set; }

        public string? Moneda { get; set; }

        public decimal? ImpuestoIgv { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? Subtotal { get; set; }

        public string? UsuarioRegistro { get; set; }

        public string? FechaRegistro { get; set; }

        public string? UsuarioModifica { get; set; }

        public string? FechaModifica { get; set; }

    }
}
