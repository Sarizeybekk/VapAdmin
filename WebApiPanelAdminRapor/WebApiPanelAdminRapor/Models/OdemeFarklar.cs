using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class OdemeFarklar
{
    public int Id { get; set; }

    public bool Tip { get; set; }

    public int Fark { get; set; }

    public bool SilindiMi { get; set; }

    public Guid SporcuFk { get; set; }

    public int DonemFk { get; set; }
}
