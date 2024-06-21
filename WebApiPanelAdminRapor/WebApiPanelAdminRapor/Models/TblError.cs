using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblError
{
    public Guid Id { get; set; }

    public int OrgFk { get; set; }

    public DateTime CihazHataTarihi { get; set; }

    public string? ErrorCodeFk { get; set; }

    public DateTime KayitTarihi { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;
}
