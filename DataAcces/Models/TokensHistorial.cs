using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class TokensHistorial
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public DateTime Fecha { get; set; }

    public string? IndEstado { get; set; }
}
