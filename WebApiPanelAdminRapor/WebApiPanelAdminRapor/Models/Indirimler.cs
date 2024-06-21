using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Indirimler
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public int Oran { get; set; }

    public int OrgFk { get; set; }

    public bool SilindiMi { get; set; }
}
