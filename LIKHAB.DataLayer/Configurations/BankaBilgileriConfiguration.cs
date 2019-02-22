
using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // BankaBilgileri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class BankaBilgileriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BankaBilgileri>
    {
        public BankaBilgileriConfiguration()
            : this("dbo")
        {
        }

        public BankaBilgileriConfiguration(string schema)
        {
            ToTable("BankaBilgileri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Banka).HasColumnName(@"Banka").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Iban).HasColumnName(@"Iban").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

}

