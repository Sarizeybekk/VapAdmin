using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Esame
{
    public int Id { get; set; }

    public int OrgFk { get; set; }

    public string? LigAdi { get; set; }

    public DateTime Tarih { get; set; }

    public string? OynanacakYer { get; set; }

    public string? RakipTakim { get; set; }

    public bool KayitliMi { get; set; }

    public bool EvSahibiMi { get; set; }

    public string? Link { get; set; }

    public string? Skor { get; set; }

    public int Hafta { get; set; }
}
