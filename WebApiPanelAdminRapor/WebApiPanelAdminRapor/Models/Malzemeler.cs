using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Malzemeler
{
    public int Id { get; set; }

    public string? MalzemeAdi { get; set; }

    public int MalzemeAdet { get; set; }

    public int ArizaAdet { get; set; }

    public DateTime OlusturulmaTarihi { get; set; }

    public string? KullaniciId { get; set; }

    public bool SilindiMi { get; set; }

    public int TamamlananAdet { get; set; }

    public double ArizaliYüzde { get; set; }

    public double TamamlananYüzde { get; set; }

    public int Toplam { get; set; }
}
