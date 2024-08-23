using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Articulo
{
    public int IdArticulo { get; set; }

    public string? Descripcion { get; set; }

    public int? IdMarca { get; set; }

    public int? IdCategoria { get; set; }

    public bool? Activo { get; set; }

    public virtual ArticuloCategorium? IdCategoriaNavigation { get; set; }

    public virtual ArticuloMarca? IdMarcaNavigation { get; set; }

    public virtual ICollection<PedidoLinea> PedidoLineas { get; set; } = new List<PedidoLinea>();
}
