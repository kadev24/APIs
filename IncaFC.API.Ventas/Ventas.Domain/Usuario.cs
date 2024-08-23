using System;
using System.Collections.Generic;

namespace Ventas.Domain;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public string? Correo { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RolUsuario> RolUsuarios { get; set; } = new List<RolUsuario>();
}
