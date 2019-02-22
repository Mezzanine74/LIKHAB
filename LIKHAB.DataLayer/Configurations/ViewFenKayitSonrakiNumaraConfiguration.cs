using LIKHAB.DataLayer.Models;

namespace LIKHAB.DataLayer.Configurations

{

    // ViewFenKayitSonrakiNumara
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ViewFenKayitSonrakiNumaraConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewFenKayitSonrakiNumara>
    {
        public ViewFenKayitSonrakiNumaraConfiguration()
            : this("dbo")
        {
        }

        public ViewFenKayitSonrakiNumaraConfiguration(string schema)
        {
            ToTable("ViewFenKayitSonrakiNumara", schema);
            HasKey(x => new { x.UniqueId, x.Yil, x.IlceId });

            Property(x => x.UniqueId).HasColumnName(@"UniqueId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Yil).HasColumnName(@"Yil").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IlceId).HasColumnName(@"IlceId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VerilecekFenKayitNo).HasColumnName(@"VerilecekFenKayitNo").HasColumnType("int").IsOptional();
        }
    }

}
