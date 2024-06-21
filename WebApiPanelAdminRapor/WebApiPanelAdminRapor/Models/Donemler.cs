using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Donemler
{
    public int Id { get; set; }

    public int Ucret { get; set; }

    public int TakimFk { get; set; }

    public string? SonOdemeTarihi { get; set; }

    public bool SilindiMi { get; set; }

    public int OrgFk { get; set; }

    public string? DonemAdi { get; set; }
}
