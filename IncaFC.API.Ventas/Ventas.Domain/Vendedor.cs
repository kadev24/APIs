using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Vendedor
{
    public int IdVendedor { get; set; }

    public string? Nombre { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
