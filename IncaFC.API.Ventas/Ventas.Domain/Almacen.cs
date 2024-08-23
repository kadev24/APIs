using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Almacen
{
    public int IdAlmacen { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<PedidoLinea> PedidoLineas { get; set; } = new List<PedidoLinea>();
}
