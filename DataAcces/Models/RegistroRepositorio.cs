using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class RegistroRepositorio
{
    public int Id { get; set; }

    public string? OrdCompra { get; set; }

    public string? Factura { get; set; }

    public decimal? Total { get; set; }

    public string? Proveedor { get; set; }

    public string? PathOrdCompra { get; set; }

    public string? PathFactura { get; set; }

    public string? IndEstado { get; set; }

    public DateTime? FecIngreso { get; set; }

    /// <summary>
    /// fecha de la factura
    /// </summary>
    public DateTime? FechaFactura { get; set; }

    public string? CorreoProveedor { get; set; }

    public string? OrdenNo { get; set; }
}
