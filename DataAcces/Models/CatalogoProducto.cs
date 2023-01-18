using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class CatalogoProducto
{
    public int Id { get; set; }

    public int? IdFactura { get; set; }

    public string? Descripcion { get; set; }

    public string? TypoDocumento { get; set; }
}
