using System;
using System.Collections.Generic;

namespace DataAcces.Models;

public partial class GeneEmail
{
    public int EmailId { get; set; }

    public string? Usuario { get; set; }

    public string? Email { get; set; }

    public int? TipoCorreo { get; set; }
}
