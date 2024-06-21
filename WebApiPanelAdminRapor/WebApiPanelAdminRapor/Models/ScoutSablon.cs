using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutSablon
{
    public int Id { get; set; }

    public string? Isim { get; set; }

    public int PuanAralik { get; set; }

    public int OrgFk { get; set; }
}
