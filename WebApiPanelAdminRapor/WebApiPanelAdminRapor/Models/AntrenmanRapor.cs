using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class AntrenmanRapor
{
    public Guid Id { get; set; }

    public Guid PlayerId { get; set; }

    public Guid UserId { get; set; }

    public DateTime Tarih { get; set; }

    public string? Sonuc { get; set; }

    public double GenelOrtalama { get; set; }
}
