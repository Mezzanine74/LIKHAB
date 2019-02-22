using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Onaylar
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class OnaylarConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Onaylar>
    {
        public OnaylarConfiguration()
            : this("dbo")
        {
        }

        public OnaylarConfiguration(string schema)
        {
            ToTable("Onaylar", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OnayKodu).HasColumnName(@"OnayKodu").HasColumnType("int").IsRequired();
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.OnaylananSatirId).HasColumnName(@"OnaylananSatirId").HasColumnType("int").IsRequired();
            Property(x => x.OnayZamani).HasColumnName(@"OnayZamani").HasColumnType("datetime").IsOptional();

        }
    }

}
