using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class ArticuloMarca
{
    public int IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
