using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class ScoutOyuncuOzellik
{
    public int Id { get; set; }

    public int GozlemciOyuncuId { get; set; }

    public int Puan { get; set; }

    public DateTime EklendigiTarih { get; set; }

    public int AltOzellikId { get; set; }

    public Guid OyuncuId { get; set; }
}
