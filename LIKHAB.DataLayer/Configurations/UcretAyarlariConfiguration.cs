using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // UcretAyarlari
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UcretAyarlariConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UcretAyarlari>
    {
        public UcretAyarlariConfiguration()
            : this("dbo")
        {
        }

        public UcretAyarlariConfiguration(string schema)
        {
            ToTable("UcretAyarlari", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsDetayi).HasColumnName(@"IsDetayi").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            Property(x => x.UcretKodu).HasColumnName(@"UcretKodu").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            Property(x => x.Kullan).HasColumnName(@"Kullan").HasColumnType("bit").IsRequired();
            Property(x => x.Parametre).HasColumnName(@"Parametre").HasColumnType("numeric").IsRequired().HasPrecision(18, 6);
        }
    }

}
