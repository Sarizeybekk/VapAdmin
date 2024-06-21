using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class TblSctGorevOyuncu
{
    public Guid GorevId { get; set; }

    public Guid OyuncuId { get; set; }

    public Guid Id { get; set; }

    public virtual TblSctGorev Gorev { get; set; } = null!;

    public virtual TblSctOyuncu Oyuncu { get; set; } = null!;
}
