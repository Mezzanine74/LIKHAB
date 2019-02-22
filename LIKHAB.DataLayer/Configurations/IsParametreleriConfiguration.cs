using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // IsParametreleri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IsParametreleriConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IsParametreleri>
    {
        public IsParametreleriConfiguration()
            : this("dbo")
        {
        }

        public IsParametreleriConfiguration(string schema)
        {
            ToTable("IsParametreleri", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Is).HasColumnName(@"Is").HasColumnType("int").IsRequired();
            Property(x => x.YuzOlcumu).HasColumnName(@"YuzOlcumu").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.AplikasyonKrokisiSayisi).HasColumnName(@"AplikasyonKrokisiSayisi").HasColumnType("int").IsOptional();
            Property(x => x.ParselSayisi).HasColumnName(@"ParselSayisi").HasColumnType("int").IsOptional();
            Property(x => x.NoktaSayisi).HasColumnName(@"NoktaSayisi").HasColumnType("int").IsOptional();
            Property(x => x.ParselAlani).HasColumnName(@"ParselAlani").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.BinaTabanAlani).HasColumnName(@"BinaTabanAlani").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.InsaatAlani).HasColumnName(@"InsaatAlani").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.BagimsizBolumSayisi).HasColumnName(@"BagimsizBolumSayisi").HasColumnType("int").IsOptional();
            Property(x => x.BinaSayisi).HasColumnName(@"BinaSayisi").HasColumnType("int").IsOptional();
            Property(x => x.PlanOrnegi).HasColumnName(@"PlanOrnegi").HasColumnType("int").IsOptional();
            Property(x => x.KatSayisi).HasColumnName(@"KatSayisi").HasColumnType("int").IsOptional();
            Property(x => x.BBolum).HasColumnName(@"B_Bolum").HasColumnType("int").IsOptional();
            Property(x => x.OdaKatsayi).HasColumnName(@"OdaKatsayi").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.AraziyeGidilecekmi).HasColumnName(@"AraziyeGidilecekmi").HasColumnType("bit").IsOptional();
            Property(x => x.AyniKisiyeAit).HasColumnName(@"AyniKisiyeAit").HasColumnType("bit").IsOptional();
            Property(x => x.OdaBirimFiyatlariniKullan).HasColumnName(@"OdaBirimFiyatlariniKullan").HasColumnType("bit").IsOptional();
            Property(x => x.Yuzde50CarpanUygula).HasColumnName(@"Yuzde50CarpanUygula").HasColumnType("bit").IsOptional();
            Property(x => x.YolUcreti).HasColumnName(@"YolUcreti").HasColumnType("numeric").IsOptional().HasPrecision(12, 2);
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Isler).WithMany(b => b.IsParametreleris).HasForeignKey(c => c.Is); // FK_IsParametreleri_Isler
        }
    }

}

