using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string? NotificationTitle { get; set; }

    public string? NotificationMessage { get; set; }

    public string? NotificationType { get; set; }
}
