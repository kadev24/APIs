using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class CondicionPago
{
    public int IdCondicionPago { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
