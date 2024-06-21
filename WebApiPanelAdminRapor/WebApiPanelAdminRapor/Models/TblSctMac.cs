using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctMac
{
    public Guid Id { get; set; }

    public DateTime Tarih { get; set; }

    public int OrgFk { get; set; }

    public int TffId { get; set; }

    public string? Stadyum { get; set; }

    public int LigId { get; set; }

    public Guid EvKulupId { get; set; }

    public Guid DeplasmanKulupId { get; set; }

    public virtual TblSctKulup DeplasmanKulup { get; set; } = null!;

    public virtual TblSctKulup EvKulup { get; set; } = null!;

    public virtual TblSctLig Lig { get; set; } = null!;

    public virtual ICollection<TblSctGorev> TblSctGorevs { get; } = new List<TblSctGorev>();

    public virtual ICollection<TblSctMacNot> TblSctMacNots { get; } = new List<TblSctMacNot>();

    public virtual ICollection<TblSctRapor> TblSctRapors { get; } = new List<TblSctRapor>();
}
