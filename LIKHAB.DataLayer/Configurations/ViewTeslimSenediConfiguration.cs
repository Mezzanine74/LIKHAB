using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewTeslimSenedi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewTeslimSenediConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewTeslimSenedi>
    {
        public ViewTeslimSenediConfiguration()
            : this("dbo")
        {
        }

        public ViewTeslimSenediConfiguration(string schema)
        {
            ToTable("ViewTeslimSenedi", schema);
            HasKey(x => new { x.IsId, x.Cinsi, x.KoyMahalle, x.Tanim, x.FenKayitTarihiGun, x.FenKayitTarihiAy, x.FenKayitTarihiYil, x.IsSahibi });

            Property(x => x.IsId).HasColumnName(@"isId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cinsi).HasColumnName(@"Cinsi").HasColumnType("nvarchar").IsRequired().HasMaxLength(18).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KoyMahalle).HasColumnName(@"Koy_Mahalle").HasColumnType("nvarchar").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PaftaNo).HasColumnName(@"PaftaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AdaNo).HasColumnName(@"AdaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ParselNo).HasColumnName(@"ParselNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.YuzOlcumu).HasColumnName(@"YuzOlcumu").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(256).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihi).HasColumnName(@"FenKayitTarihi").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.FenKayitTarihiGun).HasColumnName(@"FenKayitTarihiGUN").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihiAy).HasColumnName(@"FenKayitTarihiAY").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FenKayitTarihiYil).HasColumnName(@"FenKayitTarihiYIL").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LisansliBuroSahibi).HasColumnName(@"LisansliBuroSahibi").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.LisansliBuroSahibiUnvani).HasColumnName(@"LisansliBuroSahibiUnvani").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.IsSahibi).HasColumnName(@"isSahibi").HasColumnType("nvarchar").IsRequired().HasMaxLength(200).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BirimFiyati).HasColumnName(@"BirimFiyati").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.ToplamFiyat).HasColumnName(@"ToplamFiyat").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
        }
    }

}
