using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutAnaOzellik
{
    public int Id { get; set; }

    public string? Isim { get; set; }

    public bool SilindiMi { get; set; }

    public int OrgFk { get; set; }
}
