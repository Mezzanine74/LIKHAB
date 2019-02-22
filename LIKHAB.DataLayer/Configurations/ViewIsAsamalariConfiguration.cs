using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // View_IsAsamalari
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewIsAsamalariConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewIsAsamalari>
    {
        public ViewIsAsamalariConfiguration()
            : this("dbo")
        {
        }

        public ViewIsAsamalariConfiguration(string schema)
        {
            ToTable("View_IsAsamalari", schema);
            HasKey(x => new { x.UniqueId, x.Id, x.IsId, x.Onaylanmis, x.Fatura, x.Olcum, x.Kontrol, x.BeldEvrGeldi, x.BeldEvrGitti, x.KadEvrGeldi, x.KadEvrGitti, x.ProjeYapildi, x.OdemeAlindi, x.IsKapandi, x.MusteriyiBilgilendir });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsId).HasColumnName(@"IsId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnayaGidisZamani).HasColumnName(@"OnayaGidisZamani").HasColumnType("datetime").IsOptional();
            Property(x => x.Onaylanmis).HasColumnName(@"Onaylanmis").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnayZamani).HasColumnName(@"OnayZamani").HasColumnType("datetime").IsOptional();
            Property(x => x.Randevu).HasColumnName(@"Randevu").HasColumnType("bit").IsOptional();
            Property(x => x.RandevuWhen).HasColumnName(@"RandevuWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.Fatura).HasColumnName(@"Fatura").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FaturaWhen).HasColumnName(@"FaturaWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.Olcum).HasColumnName(@"Olcum").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OlcumWhen).HasColumnName(@"OlcumWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.Kontrol).HasColumnName(@"Kontrol").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KontrolWhen).HasColumnName(@"KontrolWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.BeldEvrGeldi).HasColumnName(@"BeldEvrGeldi").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BeldEvrGeldiWhen).HasColumnName(@"BeldEvrGeldiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.BeldEvrGitti).HasColumnName(@"BeldEvrGitti").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BeldEvrGittiWhen).HasColumnName(@"BeldEvrGittiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.KadEvrGeldi).HasColumnName(@"KadEvrGeldi").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KadEvrGeldiWhen).HasColumnName(@"KadEvrGeldiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.KadEvrGitti).HasColumnName(@"KadEvrGitti").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KadEvrGittiWhen).HasColumnName(@"KadEvrGittiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.ProjeYapildi).HasColumnName(@"ProjeYapildi").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProjeYapildiWhen).HasColumnName(@"ProjeYapildiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.OdemeAlindi).HasColumnName(@"OdemeAlindi").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OdemeAlindiWhen).HasColumnName(@"OdemeAlindiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.IsKapandi).HasColumnName(@"IsKapandi").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsKapandiWhen).HasColumnName(@"IsKapandiWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.MusteriyiBilgilendir).HasColumnName(@"MusteriyiBilgilendir").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MusteriyiBilgilendirWhen).HasColumnName(@"MusteriyiBilgilendirWhen").HasColumnType("datetime").IsOptional();
            Property(x => x.WhoCreated).HasColumnName(@"WhoCreated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhoUpdated).HasColumnName(@"WhoUpdated").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.WhenCreated).HasColumnName(@"WhenCreated").HasColumnType("datetime").IsOptional();
            Property(x => x.WhenUpdated).HasColumnName(@"WhenUpdated").HasColumnType("datetime").IsOptional();
        }
    }

}
