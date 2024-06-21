using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctKulup
{
    public Guid Id { get; set; }

    public string? Aciklama { get; set; }

    public string? LogoUrl { get; set; }

    public int TffId { get; set; }

    public DateTime? DuzenlenmeTarihi { get; set; }

    public int OrgFk { get; set; }

    public string? GenelIsim { get; set; }

    public virtual ICollection<TblSctMac> TblSctMacDeplasmanKulups { get; } = new List<TblSctMac>();

    public virtual ICollection<TblSctMac> TblSctMacEvKulups { get; } = new List<TblSctMac>();

    public virtual ICollection<TblSctOyuncu> TblSctOyuncus { get; } = new List<TblSctOyuncu>();
}
