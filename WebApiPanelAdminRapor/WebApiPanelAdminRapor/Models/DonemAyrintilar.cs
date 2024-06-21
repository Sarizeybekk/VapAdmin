using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class DonemAyrintilar
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public bool SilindiMi { get; set; }
}
