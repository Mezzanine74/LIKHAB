using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Yillar
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class YillarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Yillar>
    {
        public YillarConfiguration()
            : this("dbo")
        {
        }

        public YillarConfiguration(string schema)
        {
            ToTable("Yillar", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Yil).HasColumnName(@"Yil").HasColumnType("int").IsRequired();
        }
    }

}
