using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // MusteriTemsilDurumu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class MusteriTemsilDurumuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MusteriTemsilDurumu>
    {
        public MusteriTemsilDurumuConfiguration()
            : this("dbo")
        {
        }

        public MusteriTemsilDurumuConfiguration(string schema)
        {
            ToTable("MusteriTemsilDurumu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.StopajdaGoster).HasColumnName(@"StopajdaGoster").HasColumnType("bit").IsRequired();
            Property(x => x.IsBilgilerindeZorunluTip).HasColumnName(@"IsBilgilerindeZorunluTip").HasColumnType("bit").IsRequired();
        }
    }

}
