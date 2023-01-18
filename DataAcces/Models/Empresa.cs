using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class Empresa
{
    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public string Empresa1 { get; set; } = null!;

    public virtual ICollection<FacturasHistorial> FacturasHistorials { get; } = new List<FacturasHistorial>();
}
