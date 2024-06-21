using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctAltOzellik
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public bool SilindiMi { get; set; }

    public int OrgFk { get; set; }

    public int AnaOzellikId { get; set; }

    public virtual TblSctAnaOzellik AnaOzellik { get; set; } = null!;

    public virtual ICollection<TblSctRaporOzellik> TblSctRaporOzelliks { get; } = new List<TblSctRaporOzellik>();

    public virtual ICollection<TblSctSablonAltOzellik> TblSctSablonAltOzelliks { get; } = new List<TblSctSablonAltOzellik>();
}
