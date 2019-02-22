using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // IsAsamalari
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class IsAsamalariConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IsAsamalari>
    {
        public IsAsamalariConfiguration()
            : this("dbo")
        {
        }

        public IsAsamalariConfiguration(string schema)
        {
            ToTable("IsAsamalari", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsId).HasColumnName(@"IsId").HasColumnType("int").IsRequired();
            Property(x => x.OnayaGidisZamani).HasColumnName(@"OnayaGidisZamani").HasColumnType("datetime").IsOptional();
            Property(x => x.Onaylanmis).HasColumnName(@"Onaylanmis").HasColumnType("bit").IsRequired();
            Property(x => x.OnayZamani).HasColumnName(@"OnayZamani").HasColumnType("datetime").IsOptional();
            Property(x => x.Fatura).HasColumnName(@"Fatura").HasColumnType("bit").IsRequired();
            Property(x => x.FaturaWhen).HasColumnName(@"FaturaWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.Olcum).HasColumnName(@"Olcum").HasColumnType("bit").IsRequired();
            Property(x => x.OlcumWhen).HasColumnName(@"OlcumWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.Kontrol).HasColumnName(@"Kontrol").HasColumnType("bit").IsRequired();
            Property(x => x.KontrolWhen).HasColumnName(@"KontrolWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.BeldEvrGeldi).HasColumnName(@"BeldEvrGeldi").HasColumnType("bit").IsRequired();
            Property(x => x.BeldEvrGeldiWhen).HasColumnName(@"BeldEvrGeldiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.BeldEvrGitti).HasColumnName(@"BeldEvrGitti").HasColumnType("bit").IsRequired();
            Property(x => x.BeldEvrGittiWhen).HasColumnName(@"BeldEvrGittiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.KadEvrGeldi).HasColumnName(@"KadEvrGeldi").HasColumnType("bit").IsRequired();
            Property(x => x.KadEvrGeldiWhen).HasColumnName(@"KadEvrGeldiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.KadEvrGitti).HasColumnName(@"KadEvrGitti").HasColumnType("bit").IsRequired();
            Property(x => x.KadEvrGittiWhen).HasColumnName(@"KadEvrGittiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.ProjeYapildi).HasColumnName(@"ProjeYapildi").HasColumnType("bit").IsRequired();
            Property(x => x.ProjeYapildiWhen).HasColumnName(@"ProjeYapildiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.OdemeAlindi).HasColumnName(@"OdemeAlindi").HasColumnType("bit").IsRequired();
            Property(x => x.OdemeAlindiWhen).HasColumnName(@"OdemeAlindiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.IsKapandi).HasColumnName(@"IsKapandi").HasColumnType("bit").IsRequired();
            Property(x => x.IsKapandiWhen).HasColumnName(@"IsKapandiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.MusteriyiBilgilendir).HasColumnName(@"MusteriyiBilgilendir").HasColumnType("bit").IsRequired();
            Property(x => x.MusteriyiBilgilendirWhen).HasColumnName(@"MusteriyiBilgilendirWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoDeleted).HasColumnName(@"WhoDeleted").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenDeleted).HasColumnName(@"WhenDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.Uniqueidentifier).HasColumnName(@"Uniqueidentifier").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);


            // Foreign keys
            HasRequired(a => a.Isler).WithMany(b => b.IsAsamalaris).HasForeignKey(c => c.IsId); // FK_IsAsamalari_Isler
        }
    }

}

