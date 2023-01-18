using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class HistorialDeConsulta
{
    public int Id { get; set; }

    public string? TipoDeConsulta { get; set; }

    public string? Estado { get; set; }

    public string? Mensaje { get; set; }

    public string? CantidadDeDatosSincronizados { get; set; }
}
