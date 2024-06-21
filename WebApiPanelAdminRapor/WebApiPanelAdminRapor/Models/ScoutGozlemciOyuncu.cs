using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutGozlemciOyuncu
{
    public int Id { get; set; }

    public Guid OyuncuId { get; set; }

    public Guid GozlemciUserId { get; set; }

    public bool BizimOyuncumuzMu { get; set; }

    public DateTime EkelendigiTarih { get; set; }

    public int SablonId { get; set; }

    public int RaporDurum { get; set; }

    public int OrgFk { get; set; }
}
