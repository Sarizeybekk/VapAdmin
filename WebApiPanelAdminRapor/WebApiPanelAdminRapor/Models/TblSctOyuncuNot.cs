using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctOyuncuNot
{
    public int Id { get; set; }

    public Guid MacId { get; set; }

    public Guid EkleyenId { get; set; }

    public string? Not { get; set; }

    public Guid? OyuncuId { get; set; }

    public virtual TblSctOyuncu? Oyuncu { get; set; }
}
