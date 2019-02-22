namespace LIKHAB.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AdiSoyadi2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AdiSoyadi2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AdiSoyadi2");
        }
    }
}
