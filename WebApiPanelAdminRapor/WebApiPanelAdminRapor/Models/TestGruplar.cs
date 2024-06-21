using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TestGruplar
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public bool SilindiMi { get; set; }

    public string? Seviye { get; set; }
}
