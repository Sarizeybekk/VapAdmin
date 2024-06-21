using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class SettingStore
{
    public int Id { get; set; }

    public int OrgFk { get; set; }

    public string? Settings { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;
}
