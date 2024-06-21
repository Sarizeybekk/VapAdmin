using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutOyuncuMevki
{
    public int Id { get; set; }

    public int GozlemciOyuncuId { get; set; }

    public Guid OyuncuId { get; set; }

    public string? Mevki { get; set; }

    public int Deger { get; set; }
}
