using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Odemeler
{
    public int Id { get; set; }

    public int DonemFk { get; set; }

    public int OdemeMiktari { get; set; }

    public bool SilindiMi { get; set; }

    public Guid SporcuFk { get; set; }

    public DateTime OdemeTarihi { get; set; }
}
