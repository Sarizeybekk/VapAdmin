using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Token
{
    public Guid Id { get; set; }

    public string? Token1 { get; set; }

    public string? Owner { get; set; }

    public string? Extra { get; set; }

    public long ValidUntil { get; set; }

    public string? Purpose { get; set; }
}
