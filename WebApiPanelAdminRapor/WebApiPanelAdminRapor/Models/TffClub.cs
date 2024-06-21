using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TffClub
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Lig { get; set; }

    public string? ImageUrl { get; set; }

    public string? TffId { get; set; }

    public DateTime GuncellemeTarihi { get; set; }
}
