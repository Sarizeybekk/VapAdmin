using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctAnaOzellik
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public bool SilindiMi { get; set; }

    public int OrgFk { get; set; }

    public virtual ICollection<TblSctAltOzellik> TblSctAltOzelliks { get; } = new List<TblSctAltOzellik>();
}
