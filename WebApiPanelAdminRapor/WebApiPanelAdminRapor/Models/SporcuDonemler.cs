using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class SporcuDonemler
{
    public int Id { get; set; }

    public int DonemFk { get; set; }

    public bool SilindiMi { get; set; }

    public Guid SporcuFk { get; set; }
}
