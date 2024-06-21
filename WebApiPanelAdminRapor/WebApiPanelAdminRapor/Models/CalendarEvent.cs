using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class CalendarEvent
{
    public int Id { get; set; }

    public string? OlusturanUserId { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public DateTime Baslangic { get; set; }

    public DateTime Bitis { get; set; }

    public Guid CihazId { get; set; }

    public string? Hashtag { get; set; }

    public int OrgFk { get; set; }

    public string? Mekan { get; set; }

    public string? Tip { get; set; }
}
