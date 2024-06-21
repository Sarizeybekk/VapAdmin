using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctOyuncu
{
    public Guid Id { get; set; }

    public DateTime DogumTarihi { get; set; }

    public string? DogumYeri { get; set; }

    public int TffId { get; set; }

    public DateTime? DuzenlenmeTarihi { get; set; }

    public int OrgFk { get; set; }

    public Guid KulupId { get; set; }

    public string? AdSoyad { get; set; }

    public string? LisansNo { get; set; }

    public DateTime SozlesmeBaslangic { get; set; }

    public DateTime SozlesmeBitis { get; set; }

    public Guid UlkeId { get; set; }

    public virtual TblSctKulup Kulup { get; set; } = null!;

    public virtual ICollection<TblSctGorevOyuncu> TblSctGorevOyuncus { get; } = new List<TblSctGorevOyuncu>();

    public virtual ICollection<TblSctOyuncuNot> TblSctOyuncuNots { get; } = new List<TblSctOyuncuNot>();

    public virtual ICollection<TblSctRapor> TblSctRapors { get; } = new List<TblSctRapor>();

    public virtual TblSctUlke Ulke { get; set; } = null!;
}
