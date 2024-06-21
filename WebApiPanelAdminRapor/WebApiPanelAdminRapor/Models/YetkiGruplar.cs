using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class YetkiGruplar
{
    public int Id { get; set; }

    public string? GrupAdi { get; set; }

    public bool SilindiMi { get; set; }

    public bool SuperRole { get; set; }
}
