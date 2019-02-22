namespace LIKHAB.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addViews : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.ViewFenKayitSonrakiNumara",
            //    c => new
            //        {
            //            UniqueId = c.Guid(nullable: false),
            //            Yil = c.Int(nullable: false),
            //            IlceId = c.Int(nullable: false),
            //            VerilecekFenKayitNo = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.UniqueId, t.Yil, t.IlceId });

            //CreateTable(
            //    "dbo.View_IsAsamalari",
            //    c => new
            //        {
            //            UniqueId = c.Guid(nullable: false),
            //            id = c.Int(nullable: false),
            //            IsId = c.Int(nullable: false),
            //            Onaylanmis = c.Boolean(nullable: false),
            //            Fatura = c.Boolean(nullable: false),
            //            Olcum = c.Boolean(nullable: false),
            //            Kontrol = c.Boolean(nullable: false),
            //            BeldEvrGeldi = c.Boolean(nullable: false),
            //            BeldEvrGitti = c.Boolean(nullable: false),
            //            KadEvrGeldi = c.Boolean(nullable: false),
            //            KadEvrGitti = c.Boolean(nullable: false),
            //            ProjeYapildi = c.Boolean(nullable: false),
            //            OdemeAlindi = c.Boolean(nullable: false),
            //            IsKapandi = c.Boolean(nullable: false),
            //            MusteriyiBilgilendir = c.Boolean(nullable: false),
            //            OnayaGidisZamani = c.DateTime(),
            //            OnayZamani = c.DateTime(),
            //            Randevu = c.Boolean(),
            //            RandevuWhen = c.DateTime(),
            //            FaturaWhen = c.DateTime(),
            //            OlcumWhen = c.DateTime(),
            //            KontrolWhen = c.DateTime(),
            //            BeldEvrGeldiWhen = c.DateTime(),
            //            BeldEvrGittiWhen = c.DateTime(),
            //            KadEvrGeldiWhen = c.DateTime(),
            //            KadEvrGittiWhen = c.DateTime(),
            //            ProjeYapildiWhen = c.DateTime(),
            //            OdemeAlindiWhen = c.DateTime(),
            //            IsKapandiWhen = c.DateTime(),
            //            MusteriyiBilgilendirWhen = c.DateTime(),
            //            WhoCreated = c.String(maxLength: 50),
            //            WhoUpdated = c.String(maxLength: 50),
            //            WhenCreated = c.DateTime(),
            //            WhenUpdated = c.DateTime(),
            //        })
            //    .PrimaryKey(t => new { t.UniqueId, t.id, t.IsId, t.Onaylanmis, t.Fatura, t.Olcum, t.Kontrol, t.BeldEvrGeldi, t.BeldEvrGitti, t.KadEvrGeldi, t.KadEvrGitti, t.ProjeYapildi, t.OdemeAlindi, t.IsKapandi, t.MusteriyiBilgilendir });

            //CreateTable(
            //    "dbo.ViewIsinKucukDetayi",
            //    c => new
            //        {
            //            UniqueId = c.Guid(nullable: false),
            //            id = c.Int(nullable: false),
            //            IsinCinsi = c.String(nullable: false, maxLength: 256),
            //            AdiSoyadi = c.String(nullable: false, maxLength: 50),
            //            MusteriTemsilDurumu = c.String(maxLength: 50),
            //            AlinacakGenelToplam = c.Decimal(precision: 12, scale: 2, storeType: "numeric"),
            //        })
            //    .PrimaryKey(t => new { t.UniqueId, t.id, t.IsinCinsi, t.AdiSoyadi });

            //CreateTable(
            //    "dbo.ViewRandevuGenelOnayDurumu",
            //    c => new
            //        {
            //            RandevuId = c.Int(nullable: false),
            //            OnaySayisi = c.Int(nullable: false),
            //            Onaylanmis = c.Int(nullable: false),
            //            GerekenOnaySayisi = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.RandevuId, t.OnaySayisi, t.Onaylanmis });

            //CreateTable(
            //    "dbo.ViewRandevularIsBilgisiOlmayan",
            //    c => new
            //        {
            //            UniqueId = c.Guid(nullable: false),
            //            id = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.UniqueId, t.id });

            //CreateTable(
            //    "dbo.ViewRandevuOnayDurumu",
            //    c => new
            //        {
            //            RandevuId = c.Int(nullable: false),
            //            OnayKodu = c.Int(nullable: false),
            //            OnayVerecekUserId = c.String(nullable: false, maxLength: 128),
            //            UserName = c.String(nullable: false, maxLength: 50),
            //            AdiSoyadi = c.String(nullable: false, maxLength: 50),
            //            UniqueId = c.Long(),
            //            OnayId = c.Int(),
            //            OnayZamani = c.DateTime(),
            //        })
            //    .PrimaryKey(t => new { t.RandevuId, t.OnayKodu, t.OnayVerecekUserId, t.UserName, t.AdiSoyadi });

            //CreateTable(
            //    "dbo.ViewRandevuTalebiReportDetail",
            //    c => new
            //        {
            //            UniqueId = c.Guid(nullable: false),
            //            Tanim = c.String(nullable: false, maxLength: 256),
            //            AdiSoyadi = c.String(nullable: false, maxLength: 50),
            //            Il = c.String(nullable: false, maxLength: 50),
            //            Ilce = c.String(nullable: false, maxLength: 50),
            //            Koy_Mahalle = c.String(nullable: false, maxLength: 50),
            //            isId = c.Int(nullable: false),
            //            RandevuId = c.Int(nullable: false),
            //            Location = c.String(maxLength: 500),
            //            StartDate = c.DateTime(),
            //            EndDate = c.DateTime(),
            //            Description = c.String(),
            //            IsiOlusturan = c.String(maxLength: 50),
            //            RandevuyuVeren = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.UniqueId, t.Tanim, t.AdiSoyadi, t.Il, t.Ilce, t.Koy_Mahalle, t.isId, t.RandevuId });

            //CreateTable(
            //    "dbo.View_RaporSozlesme",
            //    c => new
            //        {
            //            IsId = c.Int(nullable: false),
            //            IlinAdi = c.String(nullable: false, maxLength: 100),
            //            Ilce = c.String(nullable: false, maxLength: 100),
            //            Koy_Mahalle = c.String(nullable: false, maxLength: 100),
            //            IsSahibi = c.String(nullable: false, maxLength: 200),
            //            IsinCinsiTanim = c.String(nullable: false, maxLength: 256),
            //            RandevuZamani = c.String(nullable: false),
            //            MalikiIBAdiSoyadi = c.String(nullable: false, maxLength: 200),
            //            IsSahibiTCkimlik_VergiNo = c.String(nullable: false, maxLength: 50),
            //            AdaParselNo = c.String(nullable: false, maxLength: 201),
            //            FenKayitTarihiNo = c.String(nullable: false),
            //            FenKayitTarihi = c.String(nullable: false),
            //            FenKayitTarihiGUN = c.String(nullable: false, maxLength: 4000),
            //            FenKayitTarihiAY = c.String(nullable: false, maxLength: 4000),
            //            FenKayitTarihiYIL = c.String(nullable: false, maxLength: 4000),
            //            IsinCinsiId = c.Int(nullable: false),
            //            IsSahibiVeUnvani = c.String(maxLength: 301),
            //            MusteriTemsilDurumuIsler = c.String(maxLength: 100),
            //            Toplam = c.String(maxLength: 4000),
            //            KDV = c.String(maxLength: 4000),
            //            GenelToplam = c.String(maxLength: 4000),
            //            IsSahibiTelefon1 = c.String(maxLength: 50),
            //            IsSahibiAdress = c.String(maxLength: 256),
            //            LisansSahibi_AdiSoyadi = c.String(maxLength: 200),
            //            LisansliBuroNo = c.String(maxLength: 50),
            //            LisansliBelgeNo = c.String(maxLength: 50),
            //            OdaSicilNo = c.String(maxLength: 50),
            //            LisansSahibiIli = c.String(maxLength: 100),
            //            PaftaNo = c.String(maxLength: 100),
            //            Yuzolcumu = c.String(maxLength: 4000),
            //        })
            //    .PrimaryKey(t => new { t.IsId, t.IlinAdi, t.Ilce, t.Koy_Mahalle, t.IsSahibi, t.IsinCinsiTanim, t.RandevuZamani, t.MalikiIBAdiSoyadi, t.IsSahibiTCkimlik_VergiNo, t.AdaParselNo, t.FenKayitTarihiNo, t.FenKayitTarihi, t.FenKayitTarihiGUN, t.FenKayitTarihiAY, t.FenKayitTarihiYIL, t.IsinCinsiId });

            //CreateTable(
            //    "dbo.ViewTeslimSenedi",
            //    c => new
            //        {
            //            isId = c.Int(nullable: false),
            //            Cinsi = c.String(nullable: false, maxLength: 18),
            //            Koy_Mahalle = c.String(nullable: false, maxLength: 100),
            //            Tanim = c.String(nullable: false, maxLength: 256),
            //            FenKayitTarihiGUN = c.String(nullable: false, maxLength: 4000),
            //            FenKayitTarihiAY = c.String(nullable: false, maxLength: 4000),
            //            FenKayitTarihiYIL = c.String(nullable: false, maxLength: 4000),
            //            isSahibi = c.String(nullable: false, maxLength: 200),
            //            PaftaNo = c.String(maxLength: 100),
            //            AdaNo = c.String(maxLength: 100),
            //            ParselNo = c.String(maxLength: 100),
            //            YuzOlcumu = c.String(maxLength: 4000),
            //            FenKayitTarihi = c.String(maxLength: 4000),
            //            LisansliBuroSahibi = c.String(maxLength: 200),
            //            LisansliBuroSahibiUnvani = c.String(maxLength: 200),
            //            BirimFiyati = c.String(maxLength: 4000),
            //            ToplamFiyat = c.String(maxLength: 4000),
            //        })
            //    .PrimaryKey(t => new { t.isId, t.Cinsi, t.Koy_Mahalle, t.Tanim, t.FenKayitTarihiGUN, t.FenKayitTarihiAY, t.FenKayitTarihiYIL, t.isSahibi });

        }

        public override void Down()
        {
            //DropTable("dbo.ViewTeslimSenedi");
            //DropTable("dbo.View_RaporSozlesme");
            //DropTable("dbo.ViewRandevuTalebiReportDetail");
            //DropTable("dbo.ViewRandevuOnayDurumu");
            //DropTable("dbo.ViewRandevularIsBilgisiOlmayan");
            //DropTable("dbo.ViewRandevuGenelOnayDurumu");
            //DropTable("dbo.ViewIsinKucukDetayi");
            //DropTable("dbo.View_IsAsamalari");
            //DropTable("dbo.ViewFenKayitSonrakiNumara");
        }
    }
}
