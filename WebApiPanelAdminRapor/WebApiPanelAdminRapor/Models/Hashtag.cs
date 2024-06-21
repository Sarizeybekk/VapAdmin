using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Hashtag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Aciklama { get; set; }

    public int OrgFk { get; set; }

    public int Status { get; set; }

    public bool IsPrivate { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;

    public virtual ICollection<Player> PlayerFks { get; } = new List<Player>();

    public virtual ICollection<AspNetUser> UserFks { get; } = new List<AspNetUser>();

    public virtual ICollection<Workout> WorkoutFks { get; } = new List<Workout>();
}
