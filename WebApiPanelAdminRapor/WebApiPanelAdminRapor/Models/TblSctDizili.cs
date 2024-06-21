using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctDizili
{
    public int Id { get; set; }

    public string? Aciklama { get; set; }

    public int OrgFk { get; set; }

    public string? KonumlarJson { get; set; }

    public virtual ICollection<TblSctRapor> TblSctRapors { get; } = new List<TblSctRapor>();
}
