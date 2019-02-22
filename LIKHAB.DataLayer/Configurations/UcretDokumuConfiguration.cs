using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // UcretDokumu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UcretDokumuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UcretDokumu>
    {
        public UcretDokumuConfiguration()
            : this("dbo")
        {
        }

        public UcretDokumuConfiguration(string schema)
        {
            ToTable("UcretDokumu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Is).HasColumnName(@"Is").HasColumnType("int").IsOptional();
            Property(x => x.YolUcreti).HasColumnName(@"YolUcreti").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.DenetimUcreti).HasColumnName(@"DenetimUcreti").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.DamgaVergisi).HasColumnName(@"DamgaVergisi").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.BelgeUcreti).HasColumnName(@"BelgeUcreti").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.KontrolUcreti).HasColumnName(@"KontrolUcreti").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.Toplam).HasColumnName(@"Toplam").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.ToplamBrutUcret).HasColumnName(@"ToplamBrutUcret").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.Stopaj20Percent).HasColumnName(@"Stopaj20percent").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.KesintilerToplami).HasColumnName(@"KesintilerToplami").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.GenelToplam).HasColumnName(@"GenelToplam").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.Kdv18Percent).HasColumnName(@"KDV18percent").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.TevkifEdilenKdv).HasColumnName(@"TevkifEdilenKDV").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.TahsilEdilenKdv).HasColumnName(@"TahsilEdilenKDV").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.NetAlinan).HasColumnName(@"NetAlinan").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.AlinacakGenelToplam).HasColumnName(@"AlinacakGenelToplam").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasOptional(a => a.Isler).WithMany(b => b.UcretDokumus).HasForeignKey(c => c.Is); // FK_UcretDokumu_Isler
        }
    }

}
