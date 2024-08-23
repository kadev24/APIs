using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int? IdCliente { get; set; }

    public int? IdVendedor { get; set; }

    public int? IdCondicionPago { get; set; }

    public DateOnly? FechaRequerida { get; set; }

    public DateTime? FechaPedido { get; set; }

    public decimal? TotalDescuento { get; set; }

    public decimal? Total { get; set; }

    public string? EstadoPedido { get; set; }

    public string? UsuarioRegistro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual CondicionPago? IdCondicionPagoNavigation { get; set; }

    public virtual Vendedor? IdVendedorNavigation { get; set; }

    public virtual ICollection<PedidoLinea> PedidoLineas { get; set; } = new List<PedidoLinea>();
}
