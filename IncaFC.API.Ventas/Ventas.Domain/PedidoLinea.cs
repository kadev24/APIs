using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class PedidoLinea
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

    public DateTime? FechaRegistro { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public virtual Almacen? IdAlmacenNavigation { get; set; }

    public virtual Articulo? IdArticuloNavigation { get; set; }

    public virtual Pedido? IdPedidoNavigation { get; set; }
}
