using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctRaporOzellik
{
    public Guid RaporId { get; set; }

    public int AltOzellikId { get; set; }

    public int Id { get; set; }

    public int Puan { get; set; }

    public virtual TblSctAltOzellik AltOzellik { get; set; } = null!;

    public virtual TblSctRapor Rapor { get; set; } = null!;
}
