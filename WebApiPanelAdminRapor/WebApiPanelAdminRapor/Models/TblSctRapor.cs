using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctRapor
{
    public Guid Id { get; set; }

    public Guid OyuncuId { get; set; }

    public Guid MacId { get; set; }

    public Guid GozlemciId { get; set; }

    public int OrgFk { get; set; }

    public DateTime Tarih { get; set; }

    public string? Pozisyon { get; set; }

    public int RaporDurum { get; set; }

    public int DizilisId { get; set; }

    public virtual TblSctDizili Dizilis { get; set; } = null!;

    public virtual TblSctMac Mac { get; set; } = null!;

    public virtual TblSctOyuncu Oyuncu { get; set; } = null!;

    public virtual ICollection<TblSctRaporNot> TblSctRaporNots { get; } = new List<TblSctRaporNot>();

    public virtual ICollection<TblSctRaporOzellik> TblSctRaporOzelliks { get; } = new List<TblSctRaporOzellik>();
}
