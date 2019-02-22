
using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Ilce
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IlceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ilce>
    {
        public IlceConfiguration()
            : this("dbo")
        {
        }

        public IlceConfiguration(string schema)
        {
            ToTable("Ilce", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Il).HasColumnName(@"Il").HasColumnType("int").IsRequired();
            Property(x => x.Ilce_).HasColumnName(@"Ilce").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);

            // Foreign keys
            HasRequired(a => a.Ili).WithMany(b => b.Ilces).HasForeignKey(c => c.Il).WillCascadeOnDelete(false); // FK_Ilce_Ili
        }
    }

}

