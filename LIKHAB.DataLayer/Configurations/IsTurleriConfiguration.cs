using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // IsTurleri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IsTurleriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IsTurleri>
    {
        public IsTurleriConfiguration()
            : this("dbo")
        {
        }

        public IsTurleriConfiguration(string schema)
        {
            ToTable("IsTurleri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
        }
    }

}
