using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class SporcuGecmi
{
    public int Id { get; set; }

    public string? TakimAdi { get; set; }

    public DateTime Baslangic { get; set; }

    public DateTime Bitis { get; set; }

    public string? SporcuId { get; set; }
}
