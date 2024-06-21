using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class DeviceResult
{
    public Guid Id { get; set; }

    public string Tip { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public Guid DeviceId { get; set; }

    public int OrgFk { get; set; }

    public Guid PlayerId { get; set; }

    public string TestAdi { get; set; } = null!;

    public int DurationSec { get; set; }

    public long TimestampUtc { get; set; }

    public string? SonucJson { get; set; }

    public Guid WorkoutId { get; set; }

    public int Durum { get; set; }

    public bool AnalizDurumu { get; set; }

    public string? TagNames { get; set; }

    public Guid UserId { get; set; }

    public virtual ICollection<ResultComment> ResultComments { get; } = new List<ResultComment>();
}
