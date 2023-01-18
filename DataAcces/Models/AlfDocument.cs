using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class AlfDocument
{
    public long IdDocument { get; set; }

    public decimal? IdEmpresa { get; set; }

    public decimal? IdFactura { get; set; }

    public string? NoFactura { get; set; }

    public string? TipoDocumento { get; set; }

    public string? IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public DateTime? FechaDocumento { get; set; }

    public string? NumeroContrato { get; set; }

    public string? Moneda { get; set; }

    public decimal? TipoCambio { get; set; }

    public string? PrecioConImpuestos { get; set; }

    public string? Vendedor { get; set; }

    public string? Nit { get; set; }

    public string? FormaPago { get; set; }

    public string? DocumentoPago { get; set; }

    public string? Estado { get; set; }

    public string? DescripcionAnulacion { get; set; }

    public decimal? ValorEfectivo { get; set; }

    public decimal? ValorCheque { get; set; }

    public decimal? ValorBoleta { get; set; }

    public decimal? ValorTc { get; set; }

    public decimal? ValorDocumento { get; set; }

    public decimal? ValorRetencionIsr { get; set; }

    public decimal? ValorRetencionIva { get; set; }

    public decimal? ValorExencionIva { get; set; }

    public string? NumeroBoleta { get; set; }

    public string? NumeroCheque { get; set; }

    public DateTime? FechaCheque { get; set; }

    public string? NombreBanco { get; set; }

    public string? Observaciones { get; set; }
}
