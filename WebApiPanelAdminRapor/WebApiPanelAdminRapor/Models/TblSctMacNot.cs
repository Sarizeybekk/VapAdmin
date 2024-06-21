using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctMacNot
{
    public int Id { get; set; }

    public Guid MacId { get; set; }

    public Guid EkleyenId { get; set; }

    public string? Not { get; set; }

    public virtual TblSctMac Mac { get; set; } = null!;
}
