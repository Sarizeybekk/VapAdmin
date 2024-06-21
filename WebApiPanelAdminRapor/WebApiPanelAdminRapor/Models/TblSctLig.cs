using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctLig
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public int OrgFk { get; set; }

    public bool SilindiMi { get; set; }

    public virtual ICollection<TblSctMac> TblSctMacs { get; } = new List<TblSctMac>();
}
