using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // Isler
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IslerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Isler>
    {
        public IslerConfiguration()
            : this("dbo")
        {
        }

        public IslerConfiguration(string schema)
        {
            ToTable("Isler", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsinCinsi).HasColumnName(@"IsinCinsi").HasColumnType("int").IsRequired();
            Property(x => x.KoyuMahallesi).HasColumnName(@"Koyu_Mahallesi").HasColumnType("int").IsRequired();
            Property(x => x.IsinTuru).HasColumnName(@"IsinTuru").HasColumnType("int").IsOptional();
            Property(x => x.KadastroyaAsliGibiVerilecek).HasColumnName(@"KadastroyaAsliGibiVerilecek").HasColumnType("bit").IsOptional();
            Property(x => x.Stopaj).HasColumnName(@"Stopaj").HasColumnType("bit").IsOptional();
            Property(x => x.Tevkifatli).HasColumnName(@"Tevkifatli").HasColumnType("bit").IsOptional();
            Property(x => x.KentselDonusum).HasColumnName(@"KentselDonusum").HasColumnType("bit").IsOptional();
            Property(x => x.YolKilometre).HasColumnName(@"YolKilometre").HasColumnType("numeric").IsOptional().HasPrecision(10, 2);
            Property(x => x.YolUcretiniElleGir).HasColumnName(@"YolUcretiniElleGir").HasColumnType("bit").IsOptional();
            Property(x => x.Musteri).HasColumnName(@"Musteri").HasColumnType("int").IsRequired();
            Property(x => x.MusteriTemsilDurumu).HasColumnName(@"MusteriTemsilDurumu").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.IsTurleri).WithMany(b => b.Islers).HasForeignKey(c => c.IsinTuru).WillCascadeOnDelete(false); // FK_Is_IsTurleri
            HasRequired(a => a.IsinCinsi_IsinCinsi).WithMany(b => b.Islers).HasForeignKey(c => c.IsinCinsi).WillCascadeOnDelete(false); // FK_Is_IsinCinsi
            HasRequired(a => a.KoyMahalle).WithMany(b => b.Islers).HasForeignKey(c => c.KoyuMahallesi).WillCascadeOnDelete(false); // FK_Is_Koy_Mahalle
            HasRequired(a => a.Musteri_Musteri).WithMany(b => b.Islers).HasForeignKey(c => c.Musteri).WillCascadeOnDelete(false); // FK_Is_Musteri
        }
    }

}
