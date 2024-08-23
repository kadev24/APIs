using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? DireccionFiscal { get; set; }

    public string? Ubigeo { get; set; }

    public string? Telefono { get; set; }

    public string? TipoCliente { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
