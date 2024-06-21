using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TffPlayer
{
    public int Id { get; set; }

    public string? DogumYeri { get; set; }

    public DateTime DogumTarihi { get; set; }

    public string? Uyruk { get; set; }

    public string? LisansNo { get; set; }

    public string? Kulup { get; set; }

    public int KulupId { get; set; }

    public DateTime SozlesmeBaslangic { get; set; }

    public DateTime SozlesmeBitis { get; set; }

    public string? Ad { get; set; }

    public string? TffId { get; set; }
}
