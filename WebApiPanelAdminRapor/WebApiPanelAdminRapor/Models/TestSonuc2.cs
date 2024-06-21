using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TestSonuc2
{
    public int Id { get; set; }

    public Guid SporcuFk { get; set; }

    public int TestAltGrupFk { get; set; }

    public string? Sonuc { get; set; }

    public DateTime Tarih { get; set; }

    public bool SilindiMi { get; set; }

    public string? TestAdi { get; set; }
}
