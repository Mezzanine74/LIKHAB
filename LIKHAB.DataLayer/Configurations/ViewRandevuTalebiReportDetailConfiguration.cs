using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewRandevuTalebiReportDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevuTalebiReportDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewRandevuTalebiReportDetail>
    {
        public ViewRandevuTalebiReportDetailConfiguration()
            : this("dbo")
        {
        }

        public ViewRandevuTalebiReportDetailConfiguration(string schema)
        {
            ToTable("ViewRandevuTalebiReportDetail", schema);
            HasKey(x => new { x.UniqueId, x.Tanim, x.AdiSoyadi, x.Il, x.Ilce, x.KoyMahalle, x.IsId, x.RandevuId });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tanim).HasColumnName(@"Tanim").HasColumnType("nvarchar").IsRequired().HasMaxLength(256).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Il).HasColumnName(@"Il").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ilce).HasColumnName(@"Ilce").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KoyMahalle).HasColumnName(@"Koy_Mahalle").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.IsId).HasColumnName(@"isId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RandevuId).HasColumnName(@"RandevuId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsiOlusturan).HasColumnName(@"IsiOlusturan").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.RandevuyuVeren).HasColumnName(@"RandevuyuVeren").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

}
