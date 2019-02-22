using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // OnayTuru
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class OnayTuruConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OnayTuru>
    {
        public OnayTuruConfiguration()
            : this("dbo")
        {
        }

        public OnayTuruConfiguration(string schema)
        {
            ToTable("OnayTuru", schema);
            HasKey(x => x.OnayKodu);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OnayKodu).HasColumnName(@"OnayKodu").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            HasMany(t => t.OnayVerecekKisis).WithMany(t => t.OnayTurus).Map(m =>
            {
                m.ToTable("OnayTuruOnayVerecekKisi", "dbo");
                m.MapLeftKey("OnayKodu");
                m.MapRightKey("OnayVerecekUserId");
            });
        }
    }

}
