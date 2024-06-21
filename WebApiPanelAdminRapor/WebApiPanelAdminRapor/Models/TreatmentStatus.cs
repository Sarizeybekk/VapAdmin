using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TreatmentStatus
{
    public int Id { get; set; }

    public int OrgFk { get; set; }

    public string? DurumIsmi { get; set; }

    public string? DurumRengi { get; set; }

    public int ToplamSakatlikSayisi { get; set; }

    public bool Sil { get; set; }
}
