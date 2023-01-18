using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class FacturasHistorial
{
    public int Id { get; set; }

    public int IdFactura { get; set; }

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public DateTime? FechaFactura { get; set; }

    public DateTime? FechaSincronizacion { get; set; }

    public string? Numfacturanav { get; set; }

    public string? Codclientenav { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
