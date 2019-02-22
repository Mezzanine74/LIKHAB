using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewRandevularIsBilgisiOlmayan
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewRandevularIsBilgisiOlmayanConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewRandevularIsBilgisiOlmayan>
    {
        public ViewRandevularIsBilgisiOlmayanConfiguration()
            : this("dbo")
        {
        }

        public ViewRandevularIsBilgisiOlmayanConfiguration(string schema)
        {
            ToTable("ViewRandevularIsBilgisiOlmayan", schema);
            HasKey(x => new { x.UniqueId, x.Id });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
