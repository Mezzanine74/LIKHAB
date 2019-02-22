using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewRandevuOnayDurumu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevuOnayDurumuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewRandevuOnayDurumu>
    {
        public ViewRandevuOnayDurumuConfiguration()
            : this("dbo")
        {
        }

        public ViewRandevuOnayDurumuConfiguration(string schema)
        {
            ToTable("ViewRandevuOnayDurumu", schema);
            HasKey(x => new { x.RandevuId, x.OnayKodu, x.OnayVerecekUserId, x.UserName, x.AdiSoyadi });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("bigint").IsOptional();
            Property(x => x.RandevuId).HasColumnName(@"RandevuId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnayId).HasColumnName(@"OnayId").HasColumnType("int").IsOptional();
            Property(x => x.OnayKodu).HasColumnName(@"OnayKodu").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnayVerecekUserId).HasColumnName(@"OnayVerecekUserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnayZamani).HasColumnName(@"OnayZamani").HasColumnType("datetime").IsOptional();
        }
    }

}
