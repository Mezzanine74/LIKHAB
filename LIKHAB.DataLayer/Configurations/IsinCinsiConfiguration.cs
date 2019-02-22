using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // IsinCinsi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IsinCinsiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IsinCinsi>
    {
        public IsinCinsiConfiguration()
            : this("dbo")
        {
        }

        public IsinCinsiConfiguration(string schema)
        {
            ToTable("IsinCinsi", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            Property(x => x.FenKayitNoSifirMi).HasColumnName(@"FenKayitNoSifirMi").HasColumnType("bit").IsRequired();
        }
    }

}
