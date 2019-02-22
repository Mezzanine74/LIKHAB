
using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Ili
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IliConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ili>
    {
        public IliConfiguration()
            : this("dbo")
        {
        }

        public IliConfiguration(string schema)
        {
            ToTable("Ili", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Il).HasColumnName(@"Il").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.IlKatsayisi).HasColumnName(@"IlKatsayisi").HasColumnType("numeric").IsRequired().HasPrecision(15, 2);
        }
    }

}

