using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class UserNotification
{
    public int NotificationFk { get; set; }

    public Guid UserFk { get; set; }

    public DateTime? Read { get; set; }
}
