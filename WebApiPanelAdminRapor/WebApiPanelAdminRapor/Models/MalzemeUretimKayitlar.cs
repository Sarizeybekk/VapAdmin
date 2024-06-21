using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class MalzemeUretimKayitlar
{
    public int Id { get; set; }

    public string? KullaniciId { get; set; }

    public string? MalzemeAdi { get; set; }

    public string? Aksiyon { get; set; }

    public DateTime IslemZamani { get; set; }
}
