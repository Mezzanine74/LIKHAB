
namespace LIKHAB.DataLayer.DBContext
{
    using LIKHAB.DataLayer.Configurations;
    using LIKHAB.DataLayer.Models;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class LikhabDBContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<BankaBilgileri> BankaBilgileris { get; set; } // BankaBilgileri
        public System.Data.Entity.DbSet<EmailKayitlari> EmailKayitlaris { get; set; } // EmailKayitlari
        public System.Data.Entity.DbSet<Ilce> Ilces { get; set; } // Ilce
        public System.Data.Entity.DbSet<Ili> Ilis { get; set; } // Ili
        public System.Data.Entity.DbSet<IsAsamalari> IsAsamalaris { get; set; } // IsAsamalari
        public System.Data.Entity.DbSet<IsBilgileri> IsBilgileris { get; set; } // IsBilgileri
        public System.Data.Entity.DbSet<IsinCinsi> IsinCinsis { get; set; } // IsinCinsi
        public System.Data.Entity.DbSet<Isler> Islers { get; set; } // Isler
        public System.Data.Entity.DbSet<IsParametreleri> IsParametreleris { get; set; } // IsParametreleri
        public System.Data.Entity.DbSet<IsTurleri> IsTurleris { get; set; } // IsTurleri
        public System.Data.Entity.DbSet<KoyMahalle> KoyMahalles { get; set; } // Koy_Mahalle
        public System.Data.Entity.DbSet<LisansliBuroBilgileri> LisansliBuroBilgileris { get; set; } // LisansliBuroBilgileri
        public System.Data.Entity.DbSet<Musteri> Musteris { get; set; } // Musteri
        public System.Data.Entity.DbSet<MusteriTemsilDurumu> MusteriTemsilDurumus { get; set; } // MusteriTemsilDurumu
        public System.Data.Entity.DbSet<Onaylar> Onaylars { get; set; } // Onaylar
        public System.Data.Entity.DbSet<OnayTuru> OnayTurus { get; set; } // OnayTuru
        public System.Data.Entity.DbSet<OnayVerecekKisi> OnayVerecekKisis { get; set; } // OnayVerecekKisi
        public System.Data.Entity.DbSet<Randevu> Randevus { get; set; } // Randevu
        public System.Data.Entity.DbSet<RandevuIlkHali> RandevuIlkHalis { get; set; } // RandevuIlkHali
        public System.Data.Entity.DbSet<UcretAyarlari> UcretAyarlaris { get; set; } // UcretAyarlari
        public System.Data.Entity.DbSet<UcretDokumu> UcretDokumus { get; set; } // UcretDokumu
        public System.Data.Entity.DbSet<Yillar> Yillars { get; set; } // Yillar
        public System.Data.Entity.DbSet<Log> Logs { get; set; } // Log

        public System.Data.Entity.DbSet<ViewFenKayitSonrakiNumara> ViewFenKayitSonrakiNumara { get; set; }
        public System.Data.Entity.DbSet<ViewIsAsamalari> ViewIsAsamalari { get; set; }
        public System.Data.Entity.DbSet<ViewIsinKucukDetayi> ViewIsinKucukDetayi { get; set; }
        public System.Data.Entity.DbSet<ViewRandevuGenelOnayDurumu> ViewRandevuGenelOnayDurumu { get; set; }
        public System.Data.Entity.DbSet<ViewRandevularIsBilgisiOlmayan> ViewRandevularIsBilgisiOlmayan { get; set; }
        public System.Data.Entity.DbSet<ViewRandevuOnayDurumu> ViewRandevuOnayDurumu { get; set; }
        public System.Data.Entity.DbSet<ViewRandevuTalebiReportDetail> ViewRandevuTalebiReportDetail { get; set; }
        public System.Data.Entity.DbSet<ViewRaporSozlesme> ViewRaporSozlesme { get; set; }
        public System.Data.Entity.DbSet<ViewTeslimSenedi> ViewTeslimSenedi { get; set; }

        public LikhabDBContext()
            : base("ApplicationServices")
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BankaBilgileriConfiguration());
            modelBuilder.Configurations.Add(new EmailKayitlariConfiguration());
            modelBuilder.Configurations.Add(new IlceConfiguration());
            modelBuilder.Configurations.Add(new IliConfiguration());
            modelBuilder.Configurations.Add(new IsAsamalariConfiguration());
            modelBuilder.Configurations.Add(new IsBilgileriConfiguration());
            modelBuilder.Configurations.Add(new IsinCinsiConfiguration());
            modelBuilder.Configurations.Add(new IslerConfiguration());
            modelBuilder.Configurations.Add(new IsParametreleriConfiguration());
            modelBuilder.Configurations.Add(new IsTurleriConfiguration());
            modelBuilder.Configurations.Add(new KoyMahalleConfiguration());
            modelBuilder.Configurations.Add(new LisansliBuroBilgileriConfiguration());
            modelBuilder.Configurations.Add(new MusteriConfiguration());
            modelBuilder.Configurations.Add(new MusteriTemsilDurumuConfiguration());
            modelBuilder.Configurations.Add(new OnaylarConfiguration());
            modelBuilder.Configurations.Add(new OnayTuruConfiguration());
            modelBuilder.Configurations.Add(new OnayVerecekKisiConfiguration());
            modelBuilder.Configurations.Add(new RandevuConfiguration());
            modelBuilder.Configurations.Add(new RandevuIlkHaliConfiguration());
            modelBuilder.Configurations.Add(new UcretAyarlariConfiguration());
            modelBuilder.Configurations.Add(new UcretDokumuConfiguration());
            modelBuilder.Configurations.Add(new YillarConfiguration());
            modelBuilder.Configurations.Add(new LogConfiguration());

            modelBuilder.Configurations.Add(new ViewFenKayitSonrakiNumaraConfiguration());
            modelBuilder.Configurations.Add(new ViewIsAsamalariConfiguration());
            modelBuilder.Configurations.Add(new ViewIsinKucukDetayiConfiguration());
            modelBuilder.Configurations.Add(new ViewRandevuGenelOnayDurumuConfiguration());
            modelBuilder.Configurations.Add(new ViewRandevularIsBilgisiOlmayanConfiguration());
            modelBuilder.Configurations.Add(new ViewRandevuOnayDurumuConfiguration());
            modelBuilder.Configurations.Add(new ViewRandevuTalebiReportDetailConfiguration());
            modelBuilder.Configurations.Add(new ViewRaporSozlesmeConfiguration());
            modelBuilder.Configurations.Add(new ViewTeslimSenediConfiguration());

        }
    }
}