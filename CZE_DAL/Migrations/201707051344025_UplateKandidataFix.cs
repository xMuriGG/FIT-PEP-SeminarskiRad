namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UplateKandidataFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GrupaKandidati", "Otplaceno", c => c.Boolean(nullable: false));
            DropColumn("dbo.UplateKandidata", "StatusUplate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UplateKandidata", "StatusUplate", c => c.Boolean(nullable: false));
            DropColumn("dbo.GrupaKandidati", "Otplaceno");
        }
    }
}
