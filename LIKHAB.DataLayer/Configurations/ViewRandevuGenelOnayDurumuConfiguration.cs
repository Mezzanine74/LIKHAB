using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewRandevuGenelOnayDurumu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevuGenelOnayDurumuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewRandevuGenelOnayDurumu>
    {
        public ViewRandevuGenelOnayDurumuConfiguration()
            : this("dbo")
        {
        }

        public ViewRandevuGenelOnayDurumuConfiguration(string schema)
        {
            ToTable("ViewRandevuGenelOnayDurumu", schema);
            HasKey(x => new { x.RandevuId, x.OnaySayisi, x.Onaylanmis });

            Property(x => x.RandevuId).HasColumnName(@"RandevuId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GerekenOnaySayisi).HasColumnName(@"GerekenOnaySayisi").HasColumnType("int").IsOptional();
            Property(x => x.OnaySayisi).HasColumnName(@"OnaySayisi").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Onaylanmis).HasColumnName(@"Onaylanmis").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
