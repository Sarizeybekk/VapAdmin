using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctGorevNot
{
    public int Id { get; set; }

    public Guid MacId { get; set; }

    public Guid EkleyenId { get; set; }

    public string? Not { get; set; }

    public Guid? GorevId { get; set; }

    public virtual TblSctGorev? Gorev { get; set; }
}
