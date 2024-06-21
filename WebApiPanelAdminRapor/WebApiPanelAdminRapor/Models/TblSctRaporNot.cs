using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctRaporNot
{
    public int Id { get; set; }

    public Guid MacId { get; set; }

    public Guid EkleyenId { get; set; }

    public string? Not { get; set; }

    public Guid? RaporId { get; set; }

    public virtual TblSctRapor? Rapor { get; set; }
}
