
using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // EmailKayitlari
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class EmailKayitlariConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmailKayitlari>
    {
        public EmailKayitlariConfiguration()
            : this("dbo")
        {
        }

        public EmailKayitlariConfiguration(string schema)
        {
            ToTable("EmailKayitlari", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Kime).HasColumnName(@"Kime").HasColumnType("nvarchar").IsOptional().HasMaxLength(1000);
            Property(x => x.Subject).HasColumnName(@"Subject").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Body).HasColumnName(@"Body").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NeZaman).HasColumnName(@"NeZaman").HasColumnType("datetime").IsOptional();
        }
    }

}

