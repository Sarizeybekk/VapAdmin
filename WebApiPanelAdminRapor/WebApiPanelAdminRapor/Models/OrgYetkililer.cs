using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class OrgYetkililer
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? Telefon { get; set; }

    public string? TelefonIki { get; set; }

    public string? Email { get; set; }

    public string? Adres { get; set; }

    public int OrgFk { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;
}
