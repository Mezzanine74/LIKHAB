
using LIKHAB.DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIKHAB.DataLayer.Configurations
{

    // BankaBilgileri
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class LogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
            : this("dbo")
        {
        }

        public LogConfiguration(string schema)
        {
            ToTable("Log", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TableName).HasColumnName(@"TableName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.LogString).HasColumnName(@"LogString").HasColumnType("nvarchar").IsRequired().HasMaxLength(2000);
            Property(x => x.TimeStamp).HasColumnName(@"TimeStamp").HasColumnType("datetime").IsOptional();
        }
    }

}

