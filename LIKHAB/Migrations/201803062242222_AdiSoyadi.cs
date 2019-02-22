namespace LIKHAB.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AdiSoyadi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AdiSoyadi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AdiSoyadi");
        }
    }
}
