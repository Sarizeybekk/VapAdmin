using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class EsamePlayer
{
    public int Id { get; set; }

    public int EsameId { get; set; }

    public Guid PlayerId { get; set; }

    public bool AsMi { get; set; }
}
