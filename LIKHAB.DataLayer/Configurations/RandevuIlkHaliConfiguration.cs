using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // RandevuIlkHali
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class RandevuIlkHaliConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RandevuIlkHali>
    {
        public RandevuIlkHaliConfiguration()
            : this("dbo")
        {
        }

        public RandevuIlkHaliConfiguration(string schema)
        {
            ToTable("RandevuIlkHali", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Is).HasColumnName(@"Is").HasColumnType("int").IsRequired();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Location).HasColumnName(@"Location").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.AllDay).HasColumnName(@"AllDay").HasColumnType("bit").IsOptional();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsOptional();
            Property(x => x.Subject).HasColumnName(@"Subject").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.Label).HasColumnName(@"Label").HasColumnType("int").IsOptional();
            Property(x => x.VerilisZamani).HasColumnName(@"VerilisZamani").HasColumnType("datetime").IsOptional();
            Property(x => x.AdiSoyadi).HasColumnName(@"AdiSoyadi").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
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
