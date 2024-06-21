using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctUlke
{
    public Guid Id { get; set; }

    public string? UlkeAdi { get; set; }

    public string? TffAdi { get; set; }

    public string? IsoKodu { get; set; }

    public virtual ICollection<TblSctOyuncu> TblSctOyuncus { get; } = new List<TblSctOyuncu>();
}
