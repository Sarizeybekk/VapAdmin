using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class OrganizasyonSporTipleri
{
    public int Id { get; set; }

    public int OrgFk { get; set; }

    public string? OrganizasyonSporTipi { get; set; }
}
