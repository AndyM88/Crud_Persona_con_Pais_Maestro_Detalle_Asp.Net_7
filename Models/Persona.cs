using System;
using System.Collections.Generic;

namespace AdministradorPersonas.Models;

public partial class Persona
{
    public int PersonaId { get; set; }

    public int? PaisId { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public virtual Pais? Pais { get; set; }
}
