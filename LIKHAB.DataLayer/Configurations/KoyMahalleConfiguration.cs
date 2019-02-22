using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Koy_Mahalle
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class KoyMahalleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<KoyMahalle>
    {
        public KoyMahalleConfiguration()
            : this("dbo")
        {
        }

        public KoyMahalleConfiguration(string schema)
        {
            ToTable("Koy_Mahalle", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Ilce).HasColumnName(@"Ilce").HasColumnType("int").IsRequired();
            Property(x => x.KoyMahalle_).HasColumnName(@"Koy_Mahalle").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.YolKilometre).HasColumnName(@"YolKilometre").HasColumnType("numeric").IsRequired().HasPrecision(18, 2);

            // Foreign keys
            HasRequired(a => a.Ilce_Ilce).WithMany(b => b.KoyMahalles).HasForeignKey(c => c.Ilce).WillCascadeOnDelete(false); // FK_Koy_Mahalle_Ilce
        }
    }

}
