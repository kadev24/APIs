using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class RolUsuario
{
    public int IdUsuarioRol { get; set; }

    public int? IdUsuario { get; set; }

    public string? Rol { get; set; }

    public bool? Activo { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
