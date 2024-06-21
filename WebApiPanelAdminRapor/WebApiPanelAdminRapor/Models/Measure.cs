using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Measure
{
    public int Id { get; set; }

    public string? Feature { get; set; }

    public int OrgFk { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; } = new List<Property>();
}
