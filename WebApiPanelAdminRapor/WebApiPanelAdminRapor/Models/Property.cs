using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Property
{
    public int Id { get; set; }

    public int MeasureFk { get; set; }

    public string? Feature { get; set; }

    public int TagId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Measure MeasureFkNavigation { get; set; } = null!;
}
