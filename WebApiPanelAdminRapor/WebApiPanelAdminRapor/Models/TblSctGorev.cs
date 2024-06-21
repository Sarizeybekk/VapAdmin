using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctGorev
{
    public Guid Id { get; set; }

    public Guid? MacId { get; set; }

    public Guid GozlemciId { get; set; }

    public Guid OlusturanId { get; set; }

    public int OrgFk { get; set; }

    public DateTime Tarih { get; set; }

    public virtual TblSctMac? Mac { get; set; }

    public virtual ICollection<TblSctGorevNot> TblSctGorevNots { get; } = new List<TblSctGorevNot>();

    public virtual ICollection<TblSctGorevOyuncu> TblSctGorevOyuncus { get; } = new List<TblSctGorevOyuncu>();
}
