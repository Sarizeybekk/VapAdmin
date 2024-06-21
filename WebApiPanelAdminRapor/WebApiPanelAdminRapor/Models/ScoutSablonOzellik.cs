using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutSablonOzellik
{
    public int Id { get; set; }

    public int SablonId { get; set; }

    public int AltOzellikId { get; set; }

    public int AnaOzellikId { get; set; }
}
