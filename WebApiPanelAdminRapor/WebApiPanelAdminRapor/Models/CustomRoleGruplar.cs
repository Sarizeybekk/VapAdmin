using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class CustomRoleGruplar
{
    public int Id { get; set; }

    public int YetkiFk { get; set; }

    public int YetkiGrupFk { get; set; }

    public bool SilindiMi { get; set; }
}
