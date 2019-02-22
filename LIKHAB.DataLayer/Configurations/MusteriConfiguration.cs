using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Musteri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class MusteriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Musteri>
    {
        public MusteriConfiguration()
            : this("dbo")
        {
        }

        public MusteriConfiguration(string schema)
        {
            ToTable("Musteri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.TCkimlikVergiNo).HasColumnName(@"TCkimlik_VergiNo").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.VergiDairesi).HasColumnName(@"VergiDairesi").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Telefon1).HasColumnName(@"Telefon1").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Telefon2).HasColumnName(@"Telefon2").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Faks).HasColumnName(@"Faks").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Eposta).HasColumnName(@"Eposta").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TemsilDurumu).HasColumnName(@"TemsilDurumu").HasColumnType("int").IsRequired();
            Property(x => x.Adress).HasColumnName(@"Adress").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.MusteriTemsilDurumu).WithMany(b => b.Musteris).HasForeignKey(c => c.TemsilDurumu).WillCascadeOnDelete(false); // FK_Musteri_MusteriTemsilDurumu
        }
    }

}
