using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctSablon
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public bool SilindiMi { get; set; }

    public int OrgFk { get; set; }

    public string? PuanAraligi { get; set; }

    public virtual ICollection<TblSctSablonAltOzellik> TblSctSablonAltOzelliks { get; } = new List<TblSctSablonAltOzellik>();
}
