namespace LIKHAB.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Log",
                c => new
                {
                    id = c.Int(nullable: false, identity: false),
                    TableName = c.String(nullable: false, maxLength: 50),
                    LogString = c.String(nullable: false, maxLength: 2000),
                    TimeStamp = c.DateTime(),
                })
                .PrimaryKey(t => t.id);

        }

        public override void Down()
        {
            DropTable("dbo.Log");
        }
    }
}
