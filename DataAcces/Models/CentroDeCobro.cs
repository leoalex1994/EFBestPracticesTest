using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class CentroDeCobro
{
    public int Id { get; set; }

    public string CodigoProyecto { get; set; } = null!;

    public string CodigoCentroCobro { get; set; } = null!;

    public string CentroCobro { get; set; } = null!;
}
