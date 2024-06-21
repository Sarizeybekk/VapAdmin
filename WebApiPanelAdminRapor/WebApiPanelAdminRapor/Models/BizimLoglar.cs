using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class BizimLoglar
{
    public int Id { get; set; }

    public string? LogMesaj { get; set; }

    public string? HangiServis { get; set; }

    public DateTime LogTarihi { get; set; }

    public string? UserId { get; set; }

    public int OrgFk { get; set; }
}
