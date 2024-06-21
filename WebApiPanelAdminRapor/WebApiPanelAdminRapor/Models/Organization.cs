using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Organization
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? ConnString { get; set; }

    public string? Unvan { get; set; }

    public string? VergiNo { get; set; }

    public bool Bireyselmi { get; set; }

    public DateTime KayitTarihi { get; set; }

    public bool AidatVarMi { get; set; }

    public virtual ICollection<AspNetUser> AspNetUsers { get; } = new List<AspNetUser>();

    public virtual ICollection<ConsumerDevice> ConsumerDevices { get; } = new List<ConsumerDevice>();

    public virtual ICollection<Hashtag> Hashtags { get; } = new List<Hashtag>();

    public virtual ICollection<Measure> Measures { get; } = new List<Measure>();

    public virtual ICollection<OrgYetkililer> OrgYetkililers { get; } = new List<OrgYetkililer>();

    public virtual ICollection<Player> Players { get; } = new List<Player>();

    public virtual SettingStore? SettingStore { get; set; }

    public virtual ICollection<TblError> TblErrors { get; } = new List<TblError>();
}
