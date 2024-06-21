using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutSablonEkstra
{
    public int Id { get; set; }

    public int SablonId { get; set; }

    public string? EkstraIsim { get; set; }
}
