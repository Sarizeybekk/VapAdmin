using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class EsameAyar
{
    public int Id { get; set; }

    public string? FormaSort { get; set; }

    public string? KaleciKazak { get; set; }

    public Guid KaptanId { get; set; }

    public Guid YetkiliId { get; set; }
}
