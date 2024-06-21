using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctSablonAltOzellik
{
    public int Id { get; set; }

    public int SablonId { get; set; }

    public int AltOzellikId { get; set; }

    public virtual TblSctAltOzellik AltOzellik { get; set; } = null!;

    public virtual TblSctSablon Sablon { get; set; } = null!;
}
