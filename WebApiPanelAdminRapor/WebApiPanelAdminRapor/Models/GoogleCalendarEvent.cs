using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class GoogleCalendarEvent
{
    public string Id { get; set; } = null!;

    public int LocalEventId { get; set; }

    public string? UserId { get; set; }
}
