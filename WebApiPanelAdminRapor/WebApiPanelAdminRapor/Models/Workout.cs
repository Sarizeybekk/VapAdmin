using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Workout
{
    public Guid Id { get; set; }

    public int MinSparkCount { get; set; }

    public string? Title { get; set; }

    public string? VideoUrl { get; set; }

    public string? DeviceType { get; set; }

    public string? Description { get; set; }

    public string? Scenario { get; set; }

    public string? JavaClassName { get; set; }

    public string? Hashtags { get; set; }

    public int OrgFk { get; set; }

    public bool IsCustom { get; set; }

    public bool IsForSale { get; set; }

    public string? Layout { get; set; }

    public DateTime? YayinlanmaTarihi { get; set; }

    public bool Sil { get; set; }

    public virtual ICollection<Hashtag> TagFks { get; } = new List<Hashtag>();
}
