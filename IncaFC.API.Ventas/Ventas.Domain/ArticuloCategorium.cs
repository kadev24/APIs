using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class ArticuloCategorium
{
    public int IdCategoria { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
