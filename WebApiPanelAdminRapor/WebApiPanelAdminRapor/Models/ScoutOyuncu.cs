using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutOyuncu
{
    public Guid Id { get; set; }

    public string? Isim { get; set; }

    public string? Soyisim { get; set; }

    public int OrgFk { get; set; }
}
