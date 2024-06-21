using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Analitik
{
    public int Id { get; set; }

    public Guid PlayerId { get; set; }

    public Guid DeviceResultId { get; set; }

    public int? DengeSkoru { get; set; }

    public double? OrtalamaHiz { get; set; }

    public double? ToplamSure { get; set; }

    public double? MaxSure { get; set; }

    public double? MinSure { get; set; }

    public string? Diger { get; set; }

    public double? OrtSure { get; set; }

    public int? SondurmeSayisi { get; set; }
}
