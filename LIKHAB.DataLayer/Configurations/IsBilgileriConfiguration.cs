using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // IsBilgileri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IsBilgileriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IsBilgileri>
    {
        public IsBilgileriConfiguration()
            : this("dbo")
        {
        }

        public IsBilgileriConfiguration(string schema)
        {
            ToTable("IsBilgileri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Is).HasColumnName(@"Is").HasColumnType("int").IsRequired();
            Property(x => x.Yili).HasColumnName(@"Yili").HasColumnType("int").IsRequired();
            Property(x => x.FenKayitNo).HasColumnName(@"FenKayitNo").HasColumnType("int").IsRequired();
            Property(x => x.FenKayitTarihi).HasColumnName(@"FenKayitTarihi").HasColumnType("smalldatetime").IsOptional();
            Property(x => x.PaftaNo).HasColumnName(@"PaftaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AdaNo).HasColumnName(@"AdaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.ParselNo).HasColumnName(@"ParselNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Takipci).HasColumnName(@"Takipci").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Maliki).HasColumnName(@"Maliki").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.Aciklama).HasColumnName(@"Aciklama").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.Cinsi).HasColumnName(@"Cinsi").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Ilgilenen).HasColumnName(@"Ilgilenen").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.FaturaNo).HasColumnName(@"FaturaNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Isler).WithMany(b => b.IsBilgileris).HasForeignKey(c => c.Is); // FK_IsBilgileri_Is
        }
    }

}
