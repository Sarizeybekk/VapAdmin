using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ConsumerDevice
{
    public Guid Id { get; set; }

    public string? Type { get; set; }

    public DateTime RegisterDate { get; set; }

    public long LastSync { get; set; }

    public int OrgFk { get; set; }

    public string? Name { get; set; }

    public string? SerialNr { get; set; }

    public string? LastAccessedBy { get; set; }

    public string? RegisteredBy { get; set; }

    public string? Birim { get; set; }

    public int ParametreSayisi { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;
}
