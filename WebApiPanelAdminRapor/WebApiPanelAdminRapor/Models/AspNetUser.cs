using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class AspNetUser
{
     public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? AvatarHash { get; set; }

    public string? UserRole { get; set; }

    public string? TagNames { get; set; }

    public int OrgFk { get; set; }

    public bool CalendarIntegrated { get; set; }

    public int Tema { get; set; }

    public int Font { get; set; }

    public bool KulupLogouKullan { get; set; }

    public string? RaporGecmisi { get; set; }

    public string? Sayfalama { get; set; }

    public int FavGamesCount { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; } = new List<AspNetUserToken>();

    public virtual Organization OrgFkNavigation { get; set; } = null!;

    public virtual ICollection<AspNetRole> Roles { get; } = new List<AspNetRole>();

    public virtual ICollection<Hashtag> TagFks { get; } = new List<Hashtag>();
}
