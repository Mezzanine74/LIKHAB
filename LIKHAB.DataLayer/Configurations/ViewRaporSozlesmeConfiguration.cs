using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // View_RaporSozlesme
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRaporSozlesmeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewRaporSozlesme>
    {
        public ViewRaporSozlesmeConfiguration()
            : this("dbo")
        {
        }

        public ViewRaporSozlesmeConfiguration(string schema)
        {
            ToTable("View_RaporSozlesme", schema);
            HasKey(x => new { x.IsId, x.IlinAdi, x.Ilce, x.KoyMahalle, x.IsSahibi, x.IsinCinsiTanim, x.RandevuZamani, x.MalikiIbAdiSoyadi, x.IsSahibiTCkimlikVergiNo, x.AdaParselNo, x.FenKayitTarihiNo, x.FenKayitTarihi, x.FenKayitTarihiGun, x.FenKayitTarihiAy, x.FenKayitTarihiYil, x.IsinCinsiId });

            Property(x => x.IsId).HasColumnName(@"IsId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IlinAdi).HasColumnName(@"IlinAdi").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ilce).HasColumnName(@"Ilce").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KoyMahalle).HasColumnName(@"Koy_Mahalle").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsSahibi).HasColumnName(@"IsSahibi").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsSahibiVeUnvani).HasColumnName(@"IsSahibiVeUnvani").HasColumnType("nvarchar").IsOptional().HasMaxLength(301);
            Property(x => x.MusteriTemsilDurumuIsler).HasColumnName(@"MusteriTemsilDurumuIsler").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.IsinCinsiTanim).HasColumnName(@"IsinCinsiTanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(256).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RandevuZamani).HasColumnName(@"RandevuZamani").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Toplam).HasColumnName(@"Toplam").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.Kdv).HasColumnName(@"KDV").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.GenelToplam).HasColumnName(@"GenelToplam").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.MalikiIbAdiSoyadi).HasColumnName(@"MalikiIBAdiSoyadi").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsSahibiTCkimlikVergiNo).HasColumnName(@"IsSahibiTCkimlik_VergiNo").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsSahibiTelefon1).HasColumnName(@"IsSahibiTelefon1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsSahibiAdress).HasColumnName(@"IsSahibiAdress").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.LisansSahibiAdiSoyadi).HasColumnName(@"LisansSahibi_AdiSoyadi").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.LisansliBuroNo).HasColumnName(@"LisansliBuroNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LisansliBelgeNo).HasColumnName(@"LisansliBelgeNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OdaSicilNo).HasColumnName(@"OdaSicilNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LisansSahibiIli).HasColumnName(@"LisansSahibiIli").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AdaParselNo).HasColumnName(@"AdaParselNo").HasColumnType("nvarchar").IsRequired().HasMaxLength(201).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PaftaNo).HasColumnName(@"PaftaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.FenKayitTarihiNo).HasColumnName(@"FenKayitTarihiNo").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihi).HasColumnName(@"FenKayitTarihi").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihiGun).HasColumnName(@"FenKayitTarihiGUN").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihiAy).HasColumnName(@"FenKayitTarihiAY").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihiYil).HasColumnName(@"FenKayitTarihiYIL").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yuzolcumu).HasColumnName(@"Yuzolcumu").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.IsinCinsiId).HasColumnName(@"IsinCinsiId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
