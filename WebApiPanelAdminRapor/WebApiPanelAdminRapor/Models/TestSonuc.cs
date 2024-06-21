using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TestSonuc
{
    public int Id { get; set; }

    public string? Tarih { get; set; }

    public bool SilindiMi { get; set; }

    public string? Sonuc { get; set; }

    public Guid SporcuFk { get; set; }
}
