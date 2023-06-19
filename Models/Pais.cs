using System;
using System.Collections.Generic;

namespace AdministradorPersonas.Models;

public partial class Pais
{
    public int PaisId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
