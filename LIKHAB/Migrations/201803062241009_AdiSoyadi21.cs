namespace LIKHAB.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AdiSoyadi21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "AdiSoyadi2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "AdiSoyadi2", c => c.String());
        }
    }
}
