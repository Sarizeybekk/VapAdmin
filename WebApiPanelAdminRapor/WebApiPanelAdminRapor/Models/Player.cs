using System;
using System.Collections.Generic;

namespace WebApiPanelAdminRapor.Models;

public partial class Player
{
    public Guid Id { get; set; }

    public int OrgFk { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public string? Tckimlik { get; set; }

    public string? LisansNo { get; set; }

    public DateTime DogumTarihi { get; set; }

    public string? CepTel { get; set; }

    public string? Email { get; set; }

    public string? KanGrubu { get; set; }

    public string? Mevki { get; set; }

    public DateTime RegisterDate { get; set; }

    public string? BaskinEl { get; set; }

    public string? BaskinAyak { get; set; }

    public string? TagNames { get; set; }

    public string? Lakap { get; set; }

    public bool Cinsiyet { get; set; }

    public bool Engelli { get; set; }

    public string? Adress { get; set; }

    public string? AdressIl { get; set; }

    public string? AdressIlce { get; set; }

    public string? Ameliyatlari { get; set; }

    public string? AnneAdi { get; set; }

    public string? AnneAdres { get; set; }

    public DateTime AnneDogumTarihi { get; set; }

    public string? AnneDurum { get; set; }

    public string? AnneEmail { get; set; }

    public string? AnneMeslek { get; set; }

    public string? AnneNot { get; set; }

    public string? AnneSoyadi { get; set; }

    public string? AnneTelefon { get; set; }

    public short AyakNumarasi { get; set; }

    public string? BabaAdi { get; set; }

    public string? BabaAdres { get; set; }

    public DateTime BabaDogumTarihi { get; set; }

    public string? BabaDurum { get; set; }

    public string? BabaEmail { get; set; }

    public string? BabaMeslek { get; set; }

    public string? BabaNot { get; set; }

    public string? BabaSoyadi { get; set; }

    public string? BabaTelefon { get; set; }

    public string? Beklentileri { get; set; }

    public string? CalistigiEgitmenler { get; set; }

    public string? DogumYeriIl { get; set; }

    public string? DogumYeriIlce { get; set; }

    public string? Hastaliklari { get; set; }

    public DateTime KulubeBaslamaTarihi { get; set; }

    public string? Not { get; set; }

    public string? OkulAdi { get; set; }

    public string? OkulAdress { get; set; }

    public string? OkulNo { get; set; }

    public DateTime OkulaGirisSaati { get; set; }

    public DateTime OkuldanCikisSaati { get; set; }

    public string? OrnekAldigiYabanciSporcular { get; set; }

    public string? OrnekAldigiYerliSporcular { get; set; }

    public string? SaglikProblemleri { get; set; }

    public DateTime SporaBaslamaTarihi { get; set; }

    public string? YaptigiSporlar { get; set; }

    public string? FavoriSporlari { get; set; }

    public string? İlgiAlanlari { get; set; }

    public int Durum { get; set; }

    public DateTime SozlesmeBitis { get; set; }

    public int Morel { get; set; }

    public string? IlkSozlesme { get; set; }

    public string? OnGoruLenLig { get; set; }

    public string? MevkiSvg { get; set; }

    public string? Uyruk { get; set; }

    public bool Sil { get; set; }

    public string? FormaNo { get; set; }

    public int LisansTur { get; set; }

    public virtual Organization OrgFkNavigation { get; set; } = null!;

    public virtual ICollection<Hashtag> TagFks { get; } = new List<Hashtag>();
}
