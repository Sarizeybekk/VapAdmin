using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class AltUstOrganization
{
    public int Id { get; set; }

    public int AnaOrgFk { get; set; }

    public int AltOrgFk { get; set; }

    public bool SilindiMi { get; set; }
}
