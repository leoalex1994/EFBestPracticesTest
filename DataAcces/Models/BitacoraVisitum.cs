using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class BitacoraVisitum
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? NombreProcedimiento { get; set; }

    public string? Url { get; set; }
}
