using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class YetkiKullanıcılar
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public bool SilindiMi { get; set; }

    public int YetkiGrupFk { get; set; }
}
