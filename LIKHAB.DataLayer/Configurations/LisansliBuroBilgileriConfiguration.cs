using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // LisansliBuroBilgileri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class LisansliBuroBilgileriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LisansliBuroBilgileri>
    {
        public LisansliBuroBilgileriConfiguration()
            : this("dbo")
        {
        }

        public LisansliBuroBilgileriConfiguration(string schema)
        {
            ToTable("LisansliBuroBilgileri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.KimlikNo).HasColumnName(@"KimlikNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Unvani).HasColumnName(@"Unvani").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.LisansliBuroNo).HasColumnName(@"LisansliBuroNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LisansliBelgeNo).HasColumnName(@"LisansliBelgeNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OdaSicilNo).HasColumnName(@"OdaSicilNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VergiNo).HasColumnName(@"VergiNo").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Ili).HasColumnName(@"Ili").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Adresi).HasColumnName(@"Adresi").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Tel).HasColumnName(@"Tel").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Faks).HasColumnName(@"Faks").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Eposta).HasColumnName(@"Eposta").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Websayfasi).HasColumnName(@"Websayfasi").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.VergiDairesi).HasColumnName(@"VergiDairesi").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Ilcesi).HasColumnName(@"Ilcesi").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
        }
    }

}
