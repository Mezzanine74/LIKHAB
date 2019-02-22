namespace LIKHAB.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankaBilgileri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Banka = c.String(nullable: false, maxLength: 50),
                    Iban = c.String(nullable: false, maxLength: 50),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    WhenUpdated = c.DateTime(),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EmailKayitlari",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Kime = c.String(maxLength: 1000),
                    Subject = c.String(maxLength: 255),
                    Body = c.String(),
                    NeZaman = c.DateTime(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Ilce",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Il = c.Int(nullable: false),
                    Ilce = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Ili", t => t.Il)
                .Index(t => t.Il);

            CreateTable(
                "dbo.Ili",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Il = c.String(nullable: false, maxLength: 100),
                    IlKatsayisi = c.Decimal(nullable: false, precision: 15, scale: 2, storeType: "numeric"),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Koy_Mahalle",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Ilce = c.Int(nullable: false),
                    Koy_Mahalle = c.String(nullable: false, maxLength: 100),
                    YolKilometre = c.Decimal(nullable: false, precision: 18, scale: 2, storeType: "numeric"),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Ilce", t => t.Ilce)
                .Index(t => t.Ilce);

            CreateTable(
                "dbo.Isler",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    IsinCinsi = c.Int(nullable: false),
                    Koyu_Mahallesi = c.Int(nullable: false),
                    IsinTuru = c.Int(),
                    KadastroyaAsliGibiVerilecek = c.Boolean(),
                    Stopaj = c.Boolean(),
                    Tevkifatli = c.Boolean(),
                    KentselDonusum = c.Boolean(),
                    YolKilometre = c.Decimal(precision: 10, scale: 2, storeType: "numeric"),
                    YolUcretiniElleGir = c.Boolean(),
                    Musteri = c.Int(nullable: false),
                    MusteriTemsilDurumu = c.String(maxLength: 100),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    WhenUpdated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.IsinCinsi", t => t.IsinCinsi)
                .ForeignKey("dbo.IsTurleri", t => t.IsinTuru)
                .ForeignKey("dbo.Koy_Mahalle", t => t.Koyu_Mahallesi)
                .ForeignKey("dbo.Musteri", t => t.Musteri)
                .Index(t => t.IsinCinsi)
                .Index(t => t.Koyu_Mahallesi)
                .Index(t => t.IsinTuru)
                .Index(t => t.Musteri);

            CreateTable(
                "dbo.IsAsamalari",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    IsId = c.Int(nullable: false),
                    OnayaGidisZamani = c.DateTime(),
                    Onaylanmis = c.Boolean(nullable: false),
                    OnayZamani = c.DateTime(),
                    Fatura = c.Boolean(nullable: false),
                    FaturaWhen = c.DateTime(),
                    Olcum = c.Boolean(nullable: false),
                    OlcumWhen = c.DateTime(),
                    Kontrol = c.Boolean(nullable: false),
                    KontrolWhen = c.DateTime(),
                    BeldEvrGeldi = c.Boolean(nullable: false),
                    BeldEvrGeldiWhen = c.DateTime(),
                    BeldEvrGitti = c.Boolean(nullable: false),
                    BeldEvrGittiWhen = c.DateTime(),
                    KadEvrGeldi = c.Boolean(nullable: false),
                    KadEvrGeldiWhen = c.DateTime(),
                    KadEvrGitti = c.Boolean(nullable: false),
                    KadEvrGittiWhen = c.DateTime(),
                    ProjeYapildi = c.Boolean(nullable: false),
                    ProjeYapildiWhen = c.DateTime(),
                    OdemeAlindi = c.Boolean(nullable: false),
                    OdemeAlindiWhen = c.DateTime(),
                    IsKapandi = c.Boolean(nullable: false),
                    IsKapandiWhen = c.DateTime(),
                    MusteriyiBilgilendir = c.Boolean(nullable: false),
                    MusteriyiBilgilendirWhen = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    WhenUpdated = c.DateTime(),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Isler", t => t.IsId, cascadeDelete: true)
                .Index(t => t.IsId);

            CreateTable(
                "dbo.IsBilgileri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Is = c.Int(nullable: false),
                    Yili = c.Int(nullable: false),
                    FenKayitNo = c.Int(nullable: false),
                    FenKayitTarihi = c.DateTime(storeType: "smalldatetime"),
                    PaftaNo = c.String(maxLength: 100),
                    AdaNo = c.String(maxLength: 100),
                    ParselNo = c.String(maxLength: 100),
                    Takipci = c.String(maxLength: 100),
                    Maliki = c.String(nullable: false, maxLength: 200),
                    Aciklama = c.String(nullable: false, maxLength: 200),
                    Cinsi = c.String(nullable: false, maxLength: 100),
                    Ilgilenen = c.String(maxLength: 200),
                    FaturaNo = c.String(maxLength: 200),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Isler", t => t.Is, cascadeDelete: true)
                .Index(t => t.Is);

            CreateTable(
                "dbo.IsinCinsi",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Tanim = c.String(nullable: false, maxLength: 256),
                    FenKayitNoSifirMi = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.IsParametreleri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Is = c.Int(nullable: false),
                    YuzOlcumu = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    AplikasyonKrokisiSayisi = c.Int(),
                    ParselSayisi = c.Int(),
                    NoktaSayisi = c.Int(),
                    ParselAlani = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    BinaTabanAlani = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    InsaatAlani = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    BagimsizBolumSayisi = c.Int(),
                    BinaSayisi = c.Int(),
                    PlanOrnegi = c.Int(),
                    KatSayisi = c.Int(),
                    B_Bolum = c.Int(),
                    OdaKatsayi = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    AraziyeGidilecekmi = c.Boolean(),
                    AyniKisiyeAit = c.Boolean(),
                    OdaBirimFiyatlariniKullan = c.Boolean(),
                    Yuzde50CarpanUygula = c.Boolean(),
                    YolUcreti = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Isler", t => t.Is, cascadeDelete: true)
                .Index(t => t.Is);

            CreateTable(
                "dbo.IsTurleri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Tanim = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Musteri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    AdiSoyadi = c.String(nullable: false, maxLength: 200),
                    TCkimlik_VergiNo = c.String(nullable: false, maxLength: 50),
                    VergiDairesi = c.String(maxLength: 50),
                    Telefon1 = c.String(maxLength: 50),
                    Telefon2 = c.String(maxLength: 50),
                    Faks = c.String(maxLength: 50),
                    Eposta = c.String(maxLength: 50),
                    TemsilDurumu = c.Int(nullable: false),
                    Adress = c.String(maxLength: 256),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MusteriTemsilDurumu", t => t.TemsilDurumu)
                .Index(t => t.TemsilDurumu);

            CreateTable(
                "dbo.MusteriTemsilDurumu",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Tanim = c.String(nullable: false, maxLength: 100),
                    StopajdaGoster = c.Boolean(nullable: false),
                    IsBilgilerindeZorunluTip = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Randevu",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Is = c.Int(nullable: false),
                    Title = c.String(maxLength: 200),
                    Description = c.String(),
                    StartDate = c.DateTime(),
                    EndDate = c.DateTime(),
                    Location = c.String(maxLength: 200),
                    AllDay = c.Boolean(),
                    Type = c.Int(),
                    Subject = c.String(maxLength: 200),
                    Status = c.Int(),
                    Label = c.Int(),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Isler", t => t.Is, cascadeDelete: true)
                .Index(t => t.Is);

            CreateTable(
                "dbo.UcretDokumu",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Is = c.Int(),
                    YolUcreti = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    DenetimUcreti = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    DamgaVergisi = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    BelgeUcreti = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    KontrolUcreti = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    Toplam = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    ToplamBrutUcret = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    Stopaj20percent = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    KesintilerToplami = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    GenelToplam = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    KDV18percent = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    TevkifEdilenKDV = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    TahsilEdilenKDV = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    NetAlinan = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    AlinacakGenelToplam = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Isler", t => t.Is)
                .Index(t => t.Is);

            CreateTable(
                "dbo.LisansliBuroBilgileri",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    KimlikNo = c.String(maxLength: 50),
                    AdiSoyadi = c.String(maxLength: 200),
                    Unvani = c.String(maxLength: 200),
                    LisansliBuroNo = c.String(maxLength: 50),
                    LisansliBelgeNo = c.String(maxLength: 50),
                    OdaSicilNo = c.String(maxLength: 50),
                    VergiNo = c.String(maxLength: 50),
                    Ili = c.String(maxLength: 100),
                    Adresi = c.String(maxLength: 256),
                    Tel = c.String(maxLength: 50),
                    Faks = c.String(maxLength: 50),
                    Eposta = c.String(maxLength: 50),
                    Websayfasi = c.String(maxLength: 50),
                    VergiDairesi = c.String(maxLength: 50),
                    Ilcesi = c.String(maxLength: 100),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Onaylar",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    OnayKodu = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 128),
                    OnaylananSatirId = c.Int(nullable: false),
                    OnayZamani = c.DateTime(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.OnayTuru",
                c => new
                {
                    OnayKodu = c.Int(nullable: false, identity: false),
                    id = c.Int(nullable: false),
                    Tanim = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.OnayKodu);

            CreateTable(
                "dbo.OnayVerecekKisi",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.UserId);

            CreateTable(
                "dbo.RandevuIlkHali",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Is = c.Int(nullable: false),
                    Title = c.String(maxLength: 200),
                    Description = c.String(),
                    StartDate = c.DateTime(),
                    EndDate = c.DateTime(),
                    Location = c.String(maxLength: 200),
                    AllDay = c.Boolean(),
                    Type = c.Int(),
                    Subject = c.String(maxLength: 200),
                    Status = c.Int(),
                    Label = c.Int(),
                    VerilisZamani = c.DateTime(),
                    AdiSoyadi = c.String(maxLength: 256),
                    WhenUpdated = c.DateTime(),
                    WhoCreated = c.String(maxLength: 50),
                    WhoUpdated = c.String(maxLength: 50),
                    WhenCreated = c.DateTime(),
                    Uniqueidentifier = c.String(maxLength: 50),
                    WhoDeleted = c.String(maxLength: 50),
                    WhenDeleted = c.DateTime(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.UcretAyarlari",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    IsDetayi = c.String(nullable: false, maxLength: 256),
                    UcretKodu = c.String(nullable: false, maxLength: 50),
                    Aciklama = c.String(nullable: false, maxLength: 256),
                    Kullan = c.Boolean(nullable: false),
                    Parametre = c.Decimal(nullable: false, precision: 18, scale: 6, storeType: "numeric"),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Yillar",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    Yil = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.OnayTuruOnayVerecekKisi",
                c => new
                {
                    OnayKodu = c.Int(nullable: false, identity: false),
                    OnayVerecekUserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.OnayKodu, t.OnayVerecekUserId })
                .ForeignKey("dbo.OnayTuru", t => t.OnayKodu, cascadeDelete: true)
                .ForeignKey("dbo.OnayVerecekKisi", t => t.OnayVerecekUserId, cascadeDelete: true)
                .Index(t => t.OnayKodu)
                .Index(t => t.OnayVerecekUserId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.OnayTuruOnayVerecekKisi", "OnayVerecekUserId", "dbo.OnayVerecekKisi");
            DropForeignKey("dbo.OnayTuruOnayVerecekKisi", "OnayKodu", "dbo.OnayTuru");
            DropForeignKey("dbo.UcretDokumu", "Is", "dbo.Isler");
            DropForeignKey("dbo.Randevu", "Is", "dbo.Isler");
            DropForeignKey("dbo.Isler", "Musteri", "dbo.Musteri");
            DropForeignKey("dbo.Musteri", "TemsilDurumu", "dbo.MusteriTemsilDurumu");
            DropForeignKey("dbo.Isler", "Koyu_Mahallesi", "dbo.Koy_Mahalle");
            DropForeignKey("dbo.Isler", "IsinTuru", "dbo.IsTurleri");
            DropForeignKey("dbo.IsParametreleri", "Is", "dbo.Isler");
            DropForeignKey("dbo.Isler", "IsinCinsi", "dbo.IsinCinsi");
            DropForeignKey("dbo.IsBilgileri", "Is", "dbo.Isler");
            DropForeignKey("dbo.IsAsamalari", "IsId", "dbo.Isler");
            DropForeignKey("dbo.Koy_Mahalle", "Ilce", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "Il", "dbo.Ili");
            DropIndex("dbo.OnayTuruOnayVerecekKisi", new[] { "OnayVerecekUserId" });
            DropIndex("dbo.OnayTuruOnayVerecekKisi", new[] { "OnayKodu" });
            DropIndex("dbo.UcretDokumu", new[] { "Is" });
            DropIndex("dbo.Randevu", new[] { "Is" });
            DropIndex("dbo.Musteri", new[] { "TemsilDurumu" });
            DropIndex("dbo.IsParametreleri", new[] { "Is" });
            DropIndex("dbo.IsBilgileri", new[] { "Is" });
            DropIndex("dbo.IsAsamalari", new[] { "IsId" });
            DropIndex("dbo.Isler", new[] { "Musteri" });
            DropIndex("dbo.Isler", new[] { "IsinTuru" });
            DropIndex("dbo.Isler", new[] { "Koyu_Mahallesi" });
            DropIndex("dbo.Isler", new[] { "IsinCinsi" });
            DropIndex("dbo.Koy_Mahalle", new[] { "Ilce" });
            DropIndex("dbo.Ilce", new[] { "Il" });
            DropTable("dbo.OnayTuruOnayVerecekKisi");
            DropTable("dbo.Yillar");
            DropTable("dbo.UcretAyarlari");
            DropTable("dbo.RandevuIlkHali");
            DropTable("dbo.OnayVerecekKisi");
            DropTable("dbo.OnayTuru");
            DropTable("dbo.Onaylar");
            DropTable("dbo.LisansliBuroBilgileri");
            DropTable("dbo.UcretDokumu");
            DropTable("dbo.Randevu");
            DropTable("dbo.MusteriTemsilDurumu");
            DropTable("dbo.Musteri");
            DropTable("dbo.IsTurleri");
            DropTable("dbo.IsParametreleri");
            DropTable("dbo.IsinCinsi");
            DropTable("dbo.IsBilgileri");
            DropTable("dbo.IsAsamalari");
            DropTable("dbo.Isler");
            DropTable("dbo.Koy_Mahalle");
            DropTable("dbo.Ili");
            DropTable("dbo.Ilce");
            DropTable("dbo.EmailKayitlari");
            DropTable("dbo.BankaBilgileri");
        }
    }
}
