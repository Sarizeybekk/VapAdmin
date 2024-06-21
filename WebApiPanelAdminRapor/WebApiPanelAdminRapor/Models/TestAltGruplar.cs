using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TestAltGruplar
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public int TestGrupFk { get; set; }

    public string? Birim { get; set; }

    public string? SonucTuru { get; set; }

    public bool SilindiMi { get; set; }

    public int Sira { get; set; }
}
