using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiPanelAdminRapor.Models;

public partial class PanelappContext : DbContext
{
    public PanelappContext()
    {
    }

    public PanelappContext(DbContextOptions<PanelappContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AltUstOrganization> AltUstOrganizations { get; set; }

    public virtual DbSet<Analitik> Analitiks { get; set; }

    public virtual DbSet<AntrenmanRapor> AntrenmanRapors { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<BizimLoglar> BizimLoglars { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<ConsumerDevice> ConsumerDevices { get; set; }

    public virtual DbSet<CustomRoleGruplar> CustomRoleGruplars { get; set; }

    public virtual DbSet<DeviceResult> DeviceResults { get; set; }

    public virtual DbSet<DonemAyrintilar> DonemAyrintilars { get; set; }

    public virtual DbSet<Donemler> Donemlers { get; set; }

    public virtual DbSet<Esame> Esames { get; set; }

    public virtual DbSet<EsameAyar> EsameAyars { get; set; }

    public virtual DbSet<EsamePlayer> EsamePlayers { get; set; }

    public virtual DbSet<FileStorage> FileStorages { get; set; }

    public virtual DbSet<GoogleCalendarEvent> GoogleCalendarEvents { get; set; }

    public virtual DbSet<Hashtag> Hashtags { get; set; }

    public virtual DbSet<Indirimler> Indirimlers { get; set; }

    public virtual DbSet<MalzemeUretimKayitlar> MalzemeUretimKayitlars { get; set; }

    public virtual DbSet<Malzemeler> Malzemelers { get; set; }

    public virtual DbSet<Measure> Measures { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OdemeFarklar> OdemeFarklars { get; set; }

    public virtual DbSet<Odemeler> Odemelers { get; set; }

    public virtual DbSet<OnurDenemeler> OnurDenemelers { get; set; }

    public virtual DbSet<OrgYetkililer> OrgYetkililers { get; set; }

    public virtual DbSet<OrganizasyonSporTipleri> OrganizasyonSporTipleris { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<ResultComment> ResultComments { get; set; }

    public virtual DbSet<ScoutAltOzellik> ScoutAltOzelliks { get; set; }

    public virtual DbSet<ScoutAnaOzellik> ScoutAnaOzelliks { get; set; }

    public virtual DbSet<ScoutGozlemciOyuncu> ScoutGozlemciOyuncus { get; set; }

    public virtual DbSet<ScoutOyuncu> ScoutOyuncus { get; set; }

    public virtual DbSet<ScoutOyuncuMevki> ScoutOyuncuMevkis { get; set; }

    public virtual DbSet<ScoutOyuncuOzellik> ScoutOyuncuOzelliks { get; set; }

    public virtual DbSet<ScoutSablon> ScoutSablons { get; set; }

    public virtual DbSet<ScoutSablonEkstra> ScoutSablonEkstras { get; set; }

    public virtual DbSet<ScoutSablonOzellik> ScoutSablonOzelliks { get; set; }

    public virtual DbSet<SettingStore> SettingStores { get; set; }

    public virtual DbSet<SporcuDonemler> SporcuDonemlers { get; set; }

    public virtual DbSet<SporcuGecmi> SporcuGecmis { get; set; }

    public virtual DbSet<SporcuIndirimler> SporcuIndirimlers { get; set; }

    public virtual DbSet<TblError> TblErrors { get; set; }

    public virtual DbSet<TblErrorCode> TblErrorCodes { get; set; }

    public virtual DbSet<TblSctAltOzellik> TblSctAltOzelliks { get; set; }

    public virtual DbSet<TblSctAnaOzellik> TblSctAnaOzelliks { get; set; }

    public virtual DbSet<TblSctDizili> TblSctDizilis { get; set; }

    public virtual DbSet<TblSctGorev> TblSctGorevs { get; set; }

    public virtual DbSet<TblSctGorevNot> TblSctGorevNots { get; set; }

    public virtual DbSet<TblSctGorevOyuncu> TblSctGorevOyuncus { get; set; }

    public virtual DbSet<TblSctKulup> TblSctKulups { get; set; }

    public virtual DbSet<TblSctLig> TblSctLigs { get; set; }

    public virtual DbSet<TblSctMac> TblSctMacs { get; set; }

    public virtual DbSet<TblSctMacNot> TblSctMacNots { get; set; }

    public virtual DbSet<TblSctOyuncu> TblSctOyuncus { get; set; }

    public virtual DbSet<TblSctOyuncuNot> TblSctOyuncuNots { get; set; }

    public virtual DbSet<TblSctRapor> TblSctRapors { get; set; }

    public virtual DbSet<TblSctRaporNot> TblSctRaporNots { get; set; }

    public virtual DbSet<TblSctRaporOzellik> TblSctRaporOzelliks { get; set; }

    public virtual DbSet<TblSctSablon> TblSctSablons { get; set; }

    public virtual DbSet<TblSctSablonAltOzellik> TblSctSablonAltOzelliks { get; set; }

    public virtual DbSet<TblSctUlke> TblSctUlkes { get; set; }

    public virtual DbSet<TestAltGruplar> TestAltGruplars { get; set; }

    public virtual DbSet<TestGruplar> TestGruplars { get; set; }

    public virtual DbSet<TestSonuc> TestSonucs { get; set; }

    public virtual DbSet<TestSonuc2> TestSonuc2s { get; set; }

    public virtual DbSet<TestSonucTarihleri> TestSonucTarihleris { get; set; }

    public virtual DbSet<TffClub> TffClubs { get; set; }

    public virtual DbSet<TffPlayer> TffPlayers { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<TreatmentStatus> TreatmentStatuses { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<Workout> Workouts { get; set; }

    public virtual DbSet<YetkiGruplar> YetkiGruplars { get; set; }

    public virtual DbSet<YetkiKullanıcılar> YetkiKullanıcılars { get; set; }

    public virtual DbSet<Yetkiler> Yetkilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("User ID=ppanel;password=d3n3m3;Server=localhost;Port=5432;Database=panelapp;Integrated Security=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AltUstOrganization>(entity =>
        {
            entity.ToTable("altUstOrganizations");

            entity.Property(e => e.AltOrgFk).HasColumnName("AltOrgFK");
            entity.Property(e => e.AnaOrgFk).HasColumnName("AnaOrgFK");
        });

        modelBuilder.Entity<Analitik>(entity =>
        {
            entity.ToTable("analitik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DengeSkoru).HasColumnName("denge_skoru");
            entity.Property(e => e.DeviceResultId).HasColumnName("device_result_id");
            entity.Property(e => e.Diger)
                .HasColumnType("jsonb")
                .HasColumnName("diger");
            entity.Property(e => e.MaxSure).HasColumnName("max_sure");
            entity.Property(e => e.MinSure).HasColumnName("min_sure");
            entity.Property(e => e.OrtSure).HasColumnName("ort_sure");
            entity.Property(e => e.OrtalamaHiz).HasColumnName("ortalama_hiz");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.SondurmeSayisi).HasColumnName("sondurme_sayisi");
            entity.Property(e => e.ToplamSure).HasColumnName("toplam_sure");
        });

        modelBuilder.Entity<AntrenmanRapor>(entity =>
        {
            entity.ToTable("antrenman_rapor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.GenelOrtalama).HasColumnName("genel_ortalama");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Sonuc)
                .HasColumnType("jsonb")
                .HasColumnName("sonuc");
            entity.Property(e => e.Tarih)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("tarih");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.OrgFk, "IX_AspNetUsers_OrgFK");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Adi).HasMaxLength(50);
            entity.Property(e => e.AvatarHash).HasComputedColumnSql("md5((\"Email\")::text)", true);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.Soyadi).HasMaxLength(50);
            entity.Property(e => e.TagNames).HasColumnType("jsonb");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.OrgFk)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });

            entity.HasMany(d => d.TagFks).WithMany(p => p.UserFks)
                .UsingEntity<Dictionary<string, object>>(
                    "UserTag",
                    r => r.HasOne<Hashtag>().WithMany()
                        .HasForeignKey("TagFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    j =>
                    {
                        j.HasKey("UserFk", "TagFk");
                        j.HasIndex(new[] { "TagFk" }, "IX_UserTags_TagFK");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BizimLoglar>(entity =>
        {
            entity.ToTable("BizimLoglar");

            entity.Property(e => e.LogTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.Property(e => e.Baslangic)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Bitis)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
        });

        modelBuilder.Entity<ConsumerDevice>(entity =>
        {
            entity.HasIndex(e => e.OrgFk, "IX_ConsumerDevices_OrgFK");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.RegisterDate).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.ConsumerDevices)
                .HasForeignKey(d => d.OrgFk)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<CustomRoleGruplar>(entity =>
        {
            entity.ToTable("CustomRoleGruplar");

            entity.Property(e => e.YetkiFk).HasColumnName("YetkiFK");
            entity.Property(e => e.YetkiGrupFk).HasColumnName("YetkiGrupFK");
        });

        modelBuilder.Entity<DeviceResult>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.SonucJson).HasColumnType("jsonb");
            entity.Property(e => e.TagNames).HasColumnType("jsonb");
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");
            entity.Property(e => e.TestAdi).HasMaxLength(50);
            entity.Property(e => e.TimestampUtc).HasColumnName("TimestampUTC");
        });

        modelBuilder.Entity<DonemAyrintilar>(entity =>
        {
            entity.ToTable("DonemAyrintilar");
        });

        modelBuilder.Entity<Donemler>(entity =>
        {
            entity.ToTable("Donemler");

            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.TakimFk).HasColumnName("TakimFK");
        });

        modelBuilder.Entity<Esame>(entity =>
        {
            entity.ToTable("Esame");

            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<EsameAyar>(entity =>
        {
            entity.ToTable("EsameAyar");
        });

        modelBuilder.Entity<EsamePlayer>(entity =>
        {
            entity.ToTable("EsamePlayer");
        });

        modelBuilder.Entity<FileStorage>(entity =>
        {
            entity.ToTable("file_storage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ContentType).HasColumnName("content_type");
            entity.Property(e => e.Etag).HasColumnName("etag");
            entity.Property(e => e.FileContent).HasColumnName("file_content");
            entity.Property(e => e.FileName).HasColumnName("file_name");
            entity.Property(e => e.OrgId).HasColumnName("org_id");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.UploadDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("upload_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Hashtag>(entity =>
        {
            entity.HasIndex(e => new { e.Name, e.OrgFk }, "IX_Hashtags_Name_OrgFK").IsUnique();

            entity.HasIndex(e => e.OrgFk, "IX_Hashtags_OrgFK");

            entity.Property(e => e.Aciklama).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.Hashtags)
                .HasForeignKey(d => d.OrgFk)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(d => d.WorkoutFks).WithMany(p => p.TagFks)
                .UsingEntity<Dictionary<string, object>>(
                    "WorkoutTag",
                    r => r.HasOne<Workout>().WithMany()
                        .HasForeignKey("WorkoutFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<Hashtag>().WithMany()
                        .HasForeignKey("TagFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    j =>
                    {
                        j.HasKey("TagFk", "WorkoutFk");
                        j.ToTable("workoutTags");
                        j.HasIndex(new[] { "WorkoutFk" }, "IX_workoutTags_WorkoutFK");
                    });
        });

        modelBuilder.Entity<Indirimler>(entity =>
        {
            entity.ToTable("Indirimler");

            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
        });

        modelBuilder.Entity<MalzemeUretimKayitlar>(entity =>
        {
            entity.ToTable("MalzemeUretimKayitlar");

            entity.Property(e => e.IslemZamani).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<Malzemeler>(entity =>
        {
            entity.ToTable("Malzemeler");

            entity.Property(e => e.OlusturulmaTarihi).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<Measure>(entity =>
        {
            entity.ToTable("measure");

            entity.HasIndex(e => e.OrgFk, "IX_measure_org_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Feature).HasColumnName("feature");
            entity.Property(e => e.OrgFk).HasColumnName("org_fk");

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.Measures).HasForeignKey(d => d.OrgFk);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Notifications_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NotificationMessage).HasColumnName("notification_message");
            entity.Property(e => e.NotificationTitle).HasColumnName("notification_title");
            entity.Property(e => e.NotificationType).HasColumnName("notification_type");
        });

        modelBuilder.Entity<OdemeFarklar>(entity =>
        {
            entity.ToTable("OdemeFarklar");

            entity.Property(e => e.DonemFk).HasColumnName("DonemFK");
            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
        });

        modelBuilder.Entity<Odemeler>(entity =>
        {
            entity.ToTable("Odemeler");

            entity.Property(e => e.DonemFk).HasColumnName("DonemFK");
            entity.Property(e => e.OdemeTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
        });

        modelBuilder.Entity<OnurDenemeler>(entity =>
        {
            entity.ToTable("OnurDenemeler");
        });

        modelBuilder.Entity<OrgYetkililer>(entity =>
        {
            entity.ToTable("orgYetkililer");

            entity.HasIndex(e => e.OrgFk, "IX_orgYetkililer_OrgFK");

            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.OrgYetkililers).HasForeignKey(d => d.OrgFk);
        });

        modelBuilder.Entity<OrganizasyonSporTipleri>(entity =>
        {
            entity.ToTable("OrganizasyonSporTipleri");

            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_Organizations_Name").IsUnique();

            entity.Property(e => e.KayitTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasIndex(e => e.OrgFk, "IX_Players_OrgFK");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AnneDogumTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.BabaDogumTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.DogumTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.FavoriSporlari).HasColumnName("favoriSporlari");
            entity.Property(e => e.KulubeBaslamaTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Morel).HasColumnName("morel");
            entity.Property(e => e.OkulaGirisSaati)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.OkuldanCikisSaati)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.RegisterDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.SozlesmeBitis)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.SporaBaslamaTarihi)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.TagNames).HasColumnType("jsonb");
            entity.Property(e => e.Tckimlik).HasMaxLength(11);

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.OrgFk)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(d => d.TagFks).WithMany(p => p.PlayerFks)
                .UsingEntity<Dictionary<string, object>>(
                    "PlayerTag",
                    r => r.HasOne<Hashtag>().WithMany()
                        .HasForeignKey("TagFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    l => l.HasOne<Player>().WithMany()
                        .HasForeignKey("PlayerFk")
                        .OnDelete(DeleteBehavior.Restrict),
                    j =>
                    {
                        j.HasKey("PlayerFk", "TagFk");
                        j.HasIndex(new[] { "TagFk" }, "IX_PlayerTags_TagFK");
                    });
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.ToTable("property");

            entity.HasIndex(e => e.MeasureFk, "IX_property_measure_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Feature).HasColumnName("feature");
            entity.Property(e => e.MeasureFk).HasColumnName("measure_fk");
            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.HasOne(d => d.MeasureFkNavigation).WithMany(p => p.Properties).HasForeignKey(d => d.MeasureFk);
        });

        modelBuilder.Entity<ResultComment>(entity =>
        {
            entity.ToTable("result_comment");

            entity.HasIndex(e => e.CommentSearchVector, "IX_result_comment_comment_search_vector").HasMethod("gin");

            entity.HasIndex(e => e.ResultFk, "IX_result_comment_result_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommentSearchVector).HasColumnName("comment_search_vector");
            entity.Property(e => e.CommentTags)
                .HasColumnType("jsonb")
                .HasColumnName("comment_tags");
            entity.Property(e => e.CommentText)
                .HasMaxLength(1000)
                .HasColumnName("comment_text");
            entity.Property(e => e.DateTimeUtc)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_time_utc");
            entity.Property(e => e.ResultFk).HasColumnName("result_fk");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ResultFkNavigation).WithMany(p => p.ResultComments)
                .HasForeignKey(d => d.ResultFk)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ScoutAltOzellik>(entity =>
        {
            entity.ToTable("scout_alt_ozellik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnaOzellikId).HasColumnName("ana_ozellik_id");
            entity.Property(e => e.Isim).HasColumnName("isim");
            entity.Property(e => e.SilindiMi).HasColumnName("silindi_mi");
        });

        modelBuilder.Entity<ScoutAnaOzellik>(entity =>
        {
            entity.ToTable("scout_ana_ozellik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isim).HasColumnName("isim");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.SilindiMi).HasColumnName("silindi_mi");
        });

        modelBuilder.Entity<ScoutGozlemciOyuncu>(entity =>
        {
            entity.ToTable("scout_gozlemci_oyuncu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BizimOyuncumuzMu).HasColumnName("bizim_oyuncumuz_mu");
            entity.Property(e => e.EkelendigiTarih)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("ekelendigi_tarih");
            entity.Property(e => e.GozlemciUserId).HasColumnName("gozlemci_user_id");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.OyuncuId).HasColumnName("oyuncu_id");
            entity.Property(e => e.RaporDurum).HasColumnName("rapor_durum");
            entity.Property(e => e.SablonId).HasColumnName("sablon_id");
        });

        modelBuilder.Entity<ScoutOyuncu>(entity =>
        {
            entity.ToTable("scout_oyuncu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Isim).HasColumnName("isim");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.Soyisim).HasColumnName("soyisim");
        });

        modelBuilder.Entity<ScoutOyuncuMevki>(entity =>
        {
            entity.ToTable("scout_oyuncu_mevki");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deger).HasColumnName("deger");
            entity.Property(e => e.GozlemciOyuncuId).HasColumnName("gozlemci_oyuncu_id");
            entity.Property(e => e.Mevki).HasColumnName("mevki");
            entity.Property(e => e.OyuncuId).HasColumnName("oyuncu_id");
        });

        modelBuilder.Entity<ScoutOyuncuOzellik>(entity =>
        {
            entity.ToTable("scout_oyuncu_ozellik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AltOzellikId).HasColumnName("alt_ozellik_id");
            entity.Property(e => e.EklendigiTarih)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("eklendigi_tarih");
            entity.Property(e => e.GozlemciOyuncuId).HasColumnName("gozlemci_oyuncu_id");
            entity.Property(e => e.OyuncuId).HasColumnName("oyuncu_id");
            entity.Property(e => e.Puan).HasColumnName("puan");
        });

        modelBuilder.Entity<ScoutSablon>(entity =>
        {
            entity.ToTable("scout_sablon");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isim).HasColumnName("isim");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");
            entity.Property(e => e.PuanAralik).HasColumnName("puan_aralik");
        });

        modelBuilder.Entity<ScoutSablonEkstra>(entity =>
        {
            entity.ToTable("scout_sablon_ekstra");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EkstraIsim).HasColumnName("ekstra_isim");
            entity.Property(e => e.SablonId).HasColumnName("sablon_id");
        });

        modelBuilder.Entity<ScoutSablonOzellik>(entity =>
        {
            entity.ToTable("scout_sablon_ozellik");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AltOzellikId).HasColumnName("alt_ozellik_id");
            entity.Property(e => e.AnaOzellikId).HasColumnName("ana_ozellik_id");
            entity.Property(e => e.SablonId).HasColumnName("sablon_id");
        });

        modelBuilder.Entity<SettingStore>(entity =>
        {
            entity.HasIndex(e => e.OrgFk, "IX_SettingStores_org_fk").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrgFk).HasColumnName("org_fk");
            entity.Property(e => e.Settings).HasColumnType("jsonb");

            entity.HasOne(d => d.OrgFkNavigation).WithOne(p => p.SettingStore).HasForeignKey<SettingStore>(d => d.OrgFk);
        });

        modelBuilder.Entity<SporcuDonemler>(entity =>
        {
            entity.ToTable("SporcuDonemler");

            entity.Property(e => e.DonemFk).HasColumnName("DonemFK");
            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
        });

        modelBuilder.Entity<SporcuGecmi>(entity =>
        {
            entity.Property(e => e.Baslangic).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Bitis).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<SporcuIndirimler>(entity =>
        {
            entity.ToTable("SporcuIndirimler");

            entity.Property(e => e.DonemFk).HasColumnName("DonemFK");
            entity.Property(e => e.IndirimFk).HasColumnName("IndirimFK");
            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
        });

        modelBuilder.Entity<TblError>(entity =>
        {
            entity.ToTable("tbl_Errors");

            entity.HasIndex(e => e.OrgFk, "IX_tbl_Errors_OrgFK");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CihazHataTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.ErrorCodeFk).HasColumnName("ErrorCodeFK");
            entity.Property(e => e.KayitTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.OrgFk).HasColumnName("OrgFK");

            entity.HasOne(d => d.OrgFkNavigation).WithMany(p => p.TblErrors).HasForeignKey(d => d.OrgFk);
        });

        modelBuilder.Entity<TblErrorCode>(entity =>
        {
            entity.ToTable("tbl_ErrorCodes");
        });

        modelBuilder.Entity<TblSctAltOzellik>(entity =>
        {
            entity.ToTable("tbl_sct_alt_ozellik");

            entity.HasIndex(e => e.AnaOzellikId, "IX_tbl_sct_alt_ozellik_AnaOzellikId");

            entity.HasOne(d => d.AnaOzellik).WithMany(p => p.TblSctAltOzelliks).HasForeignKey(d => d.AnaOzellikId);
        });

        modelBuilder.Entity<TblSctAnaOzellik>(entity =>
        {
            entity.ToTable("tbl_sct_ana_ozellik");
        });

        modelBuilder.Entity<TblSctDizili>(entity =>
        {
            entity.ToTable("tbl_sct_dizilis");
        });

        modelBuilder.Entity<TblSctGorev>(entity =>
        {
            entity.ToTable("tbl_sct_gorev");

            entity.HasIndex(e => e.MacId, "IX_tbl_sct_gorev_MacId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Mac).WithMany(p => p.TblSctGorevs)
                .HasForeignKey(d => d.MacId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TblSctGorevNot>(entity =>
        {
            entity.ToTable("tbl_sct_gorev_not");

            entity.HasIndex(e => e.GorevId, "IX_tbl_sct_gorev_not_GorevId");

            entity.HasOne(d => d.Gorev).WithMany(p => p.TblSctGorevNots)
                .HasForeignKey(d => d.GorevId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TblSctGorevOyuncu>(entity =>
        {
            entity.HasKey(e => new { e.GorevId, e.OyuncuId });

            entity.ToTable("tbl_sct_gorev_oyuncu");

            entity.HasIndex(e => e.OyuncuId, "IX_tbl_sct_gorev_oyuncu_OyuncuId");

            entity.HasOne(d => d.Gorev).WithMany(p => p.TblSctGorevOyuncus).HasForeignKey(d => d.GorevId);

            entity.HasOne(d => d.Oyuncu).WithMany(p => p.TblSctGorevOyuncus).HasForeignKey(d => d.OyuncuId);
        });

        modelBuilder.Entity<TblSctKulup>(entity =>
        {
            entity.ToTable("tbl_sct_kulup");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DuzenlenmeTarihi).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<TblSctLig>(entity =>
        {
            entity.ToTable("tbl_sct_lig");
        });

        modelBuilder.Entity<TblSctMac>(entity =>
        {
            entity.ToTable("tbl_sct_mac");

            entity.HasIndex(e => e.DeplasmanKulupId, "IX_tbl_sct_mac_DeplasmanKulupId");

            entity.HasIndex(e => e.EvKulupId, "IX_tbl_sct_mac_EvKulupId");

            entity.HasIndex(e => e.LigId, "IX_tbl_sct_mac_LigId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.DeplasmanKulup).WithMany(p => p.TblSctMacDeplasmanKulups).HasForeignKey(d => d.DeplasmanKulupId);

            entity.HasOne(d => d.EvKulup).WithMany(p => p.TblSctMacEvKulups).HasForeignKey(d => d.EvKulupId);

            entity.HasOne(d => d.Lig).WithMany(p => p.TblSctMacs).HasForeignKey(d => d.LigId);
        });

        modelBuilder.Entity<TblSctMacNot>(entity =>
        {
            entity.ToTable("tbl_sct_mac_not");

            entity.HasIndex(e => e.MacId, "IX_tbl_sct_mac_not_MacId");

            entity.HasOne(d => d.Mac).WithMany(p => p.TblSctMacNots).HasForeignKey(d => d.MacId);
        });

        modelBuilder.Entity<TblSctOyuncu>(entity =>
        {
            entity.ToTable("tbl_sct_oyuncu");

            entity.HasIndex(e => e.KulupId, "IX_tbl_sct_oyuncu_KulupId");

            entity.HasIndex(e => e.UlkeId, "IX_tbl_sct_oyuncu_UlkeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DogumTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DuzenlenmeTarihi).HasColumnType("timestamp without time zone");
            entity.Property(e => e.SozlesmeBaslangic)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.SozlesmeBitis)
                .HasDefaultValueSql("'0001-01-01 00:00:00'::timestamp without time zone")
                .HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Kulup).WithMany(p => p.TblSctOyuncus).HasForeignKey(d => d.KulupId);

            entity.HasOne(d => d.Ulke).WithMany(p => p.TblSctOyuncus).HasForeignKey(d => d.UlkeId);
        });

        modelBuilder.Entity<TblSctOyuncuNot>(entity =>
        {
            entity.ToTable("tbl_sct_oyuncu_not");

            entity.HasIndex(e => e.OyuncuId, "IX_tbl_sct_oyuncu_not_OyuncuId");

            entity.HasOne(d => d.Oyuncu).WithMany(p => p.TblSctOyuncuNots)
                .HasForeignKey(d => d.OyuncuId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TblSctRapor>(entity =>
        {
            entity.ToTable("tbl_sct_rapor");

            entity.HasIndex(e => e.DizilisId, "IX_tbl_sct_rapor_DizilisId");

            entity.HasIndex(e => e.MacId, "IX_tbl_sct_rapor_MacId");

            entity.HasIndex(e => e.OyuncuId, "IX_tbl_sct_rapor_OyuncuId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Dizilis).WithMany(p => p.TblSctRapors).HasForeignKey(d => d.DizilisId);

            entity.HasOne(d => d.Mac).WithMany(p => p.TblSctRapors).HasForeignKey(d => d.MacId);

            entity.HasOne(d => d.Oyuncu).WithMany(p => p.TblSctRapors).HasForeignKey(d => d.OyuncuId);
        });

        modelBuilder.Entity<TblSctRaporNot>(entity =>
        {
            entity.ToTable("tbl_sct_rapor_not");

            entity.HasIndex(e => e.RaporId, "IX_tbl_sct_rapor_not_RaporId");

            entity.HasOne(d => d.Rapor).WithMany(p => p.TblSctRaporNots)
                .HasForeignKey(d => d.RaporId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<TblSctRaporOzellik>(entity =>
        {
            entity.HasKey(e => new { e.RaporId, e.AltOzellikId });

            entity.ToTable("tbl_sct_rapor_ozellik");

            entity.HasIndex(e => e.AltOzellikId, "IX_tbl_sct_rapor_ozellik_AltOzellikId");

            entity.HasOne(d => d.AltOzellik).WithMany(p => p.TblSctRaporOzelliks).HasForeignKey(d => d.AltOzellikId);

            entity.HasOne(d => d.Rapor).WithMany(p => p.TblSctRaporOzelliks).HasForeignKey(d => d.RaporId);
        });

        modelBuilder.Entity<TblSctSablon>(entity =>
        {
            entity.ToTable("tbl_sct_sablon");
        });

        modelBuilder.Entity<TblSctSablonAltOzellik>(entity =>
        {
            entity.ToTable("tbl_sct_sablon_alt_ozellik");

            entity.HasIndex(e => e.AltOzellikId, "IX_tbl_sct_sablon_alt_ozellik_AltOzellikId");

            entity.HasIndex(e => e.SablonId, "IX_tbl_sct_sablon_alt_ozellik_SablonId");

            entity.HasOne(d => d.AltOzellik).WithMany(p => p.TblSctSablonAltOzelliks).HasForeignKey(d => d.AltOzellikId);

            entity.HasOne(d => d.Sablon).WithMany(p => p.TblSctSablonAltOzelliks).HasForeignKey(d => d.SablonId);
        });

        modelBuilder.Entity<TblSctUlke>(entity =>
        {
            entity.ToTable("tbl_sct_ulke");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TestAltGruplar>(entity =>
        {
            entity.ToTable("TestAltGruplar");

            entity.Property(e => e.TestGrupFk).HasColumnName("TestGrupFK");
        });

        modelBuilder.Entity<TestGruplar>(entity =>
        {
            entity.ToTable("TestGruplar");
        });

        modelBuilder.Entity<TestSonuc>(entity =>
        {
            entity.ToTable("TestSonuc");

            entity.Property(e => e.Sonuc).HasColumnType("jsonb");
            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
        });

        modelBuilder.Entity<TestSonuc2>(entity =>
        {
            entity.ToTable("TestSonuc2");

            entity.Property(e => e.SporcuFk).HasColumnName("SporcuFK");
            entity.Property(e => e.Tarih).HasColumnType("timestamp without time zone");
            entity.Property(e => e.TestAltGrupFk).HasColumnName("TestAltGrupFK");
        });

        modelBuilder.Entity<TestSonucTarihleri>(entity =>
        {
            entity.ToTable("TestSonucTarihleri");

            entity.Property(e => e.TestSonucTarihi).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<TffClub>(entity =>
        {
            entity.ToTable("tff_clubs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adi).HasColumnName("adi");
            entity.Property(e => e.GuncellemeTarihi)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("guncelleme_tarihi");
            entity.Property(e => e.ImageUrl).HasColumnName("image_url");
            entity.Property(e => e.Lig).HasColumnName("lig");
            entity.Property(e => e.TffId).HasColumnName("tff_id");
        });

        modelBuilder.Entity<TffPlayer>(entity =>
        {
            entity.ToTable("tff_players");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad).HasColumnName("ad");
            entity.Property(e => e.DogumTarihi)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dogum_tarihi");
            entity.Property(e => e.DogumYeri).HasColumnName("dogum_yeri");
            entity.Property(e => e.Kulup).HasColumnName("kulup");
            entity.Property(e => e.KulupId).HasColumnName("kulup_id");
            entity.Property(e => e.LisansNo).HasColumnName("lisans_no");
            entity.Property(e => e.SozlesmeBaslangic)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sozlesme_baslangic");
            entity.Property(e => e.SozlesmeBitis)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sozlesme_bitis");
            entity.Property(e => e.TffId).HasColumnName("tff_id");
            entity.Property(e => e.Uyruk).HasColumnName("uyruk");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasIndex(e => new { e.Owner, e.Purpose }, "IX_Tokens_Owner_Purpose").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Token1).HasColumnName("Token");
        });

        modelBuilder.Entity<TreatmentStatus>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrgFk).HasColumnName("org_fk");
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.HasKey(e => new { e.NotificationFk, e.UserFk });

            entity.HasIndex(e => new { e.NotificationFk, e.UserFk }, "IX_UserNotifications_notification_fk_user_fk").IsUnique();

            entity.Property(e => e.NotificationFk).HasColumnName("notification_fk");
            entity.Property(e => e.UserFk).HasColumnName("user_fk");
            entity.Property(e => e.Read)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("read");
        });

        modelBuilder.Entity<Workout>(entity =>
        {
            entity.ToTable("workouts");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DeviceType).HasColumnName("device_type");
            entity.Property(e => e.Hashtags)
                .HasColumnType("jsonb")
                .HasColumnName("hashtags");
            entity.Property(e => e.IsCustom).HasColumnName("is_custom");
            entity.Property(e => e.IsForSale).HasColumnName("is_for_sale");
            entity.Property(e => e.JavaClassName).HasColumnName("java_class_name");
            entity.Property(e => e.Layout).HasColumnName("layout");
            entity.Property(e => e.MinSparkCount).HasColumnName("min_spark_count");
            entity.Property(e => e.OrgFk).HasColumnName("org_fk");
            entity.Property(e => e.Scenario)
                .HasColumnType("jsonb")
                .HasColumnName("scenario");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.VideoUrl).HasColumnName("video_url");
            entity.Property(e => e.YayinlanmaTarihi)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("yayinlanma_tarihi");
        });

        modelBuilder.Entity<YetkiGruplar>(entity =>
        {
            entity.ToTable("YetkiGruplar");
        });

        modelBuilder.Entity<YetkiKullanıcılar>(entity =>
        {
            entity.ToTable("YetkiKullanıcılar");

            entity.Property(e => e.YetkiGrupFk).HasColumnName("YetkiGrupFK");
        });

        modelBuilder.Entity<Yetkiler>(entity =>
        {
            entity.ToTable("Yetkiler");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
