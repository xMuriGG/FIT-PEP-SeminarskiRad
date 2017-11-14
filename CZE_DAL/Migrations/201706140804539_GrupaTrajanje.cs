namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GrupaTrajanje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grupe", "UToku", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grupe", "UToku");
        }
    }
}
