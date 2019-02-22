using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // OnayVerecekKisi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class OnayVerecekKisiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OnayVerecekKisi>
    {
        public OnayVerecekKisiConfiguration()
            : this("dbo")
        {
        }

        public OnayVerecekKisiConfiguration(string schema)
        {
            ToTable("OnayVerecekKisi", schema);
            HasKey(x => x.UserId);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
