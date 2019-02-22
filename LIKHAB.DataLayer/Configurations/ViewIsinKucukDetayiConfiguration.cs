using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewIsinKucukDetayi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewIsinKucukDetayiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewIsinKucukDetayi>
    {
        public ViewIsinKucukDetayiConfiguration()
            : this("dbo")
        {
        }

        public ViewIsinKucukDetayiConfiguration(string schema)
        {
            ToTable("ViewIsinKucukDetayi", schema);
            HasKey(x => new { x.UniqueId, x.Id, x.IsinCinsi, x.AdiSoyadi });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsinCinsi).HasColumnName(@"IsinCinsi").HasColumnType("nvarchar").IsRequired().HasMaxLength(256).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MusteriTemsilDurumu).HasColumnName(@"MusteriTemsilDurumu").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.AlinacakGenelToplam).HasColumnName(@"AlinacakGenelToplam").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
        }
    }

}
