using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Yetkiler
{
    public int Id { get; set; }

    public string? YetkiAdi { get; set; }

    public bool SilindiMi { get; set; }

    public string? YetkiAciklama { get; set; }

    public bool SuperYetki { get; set; }
}
