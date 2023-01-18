using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class CatalogoDeContrato
{
    public int IdContrato { get; set; }

    public string? NombreContrato { get; set; }

    public string? CcNav { get; set; }

    public string? TipoContrato { get; set; }
}
