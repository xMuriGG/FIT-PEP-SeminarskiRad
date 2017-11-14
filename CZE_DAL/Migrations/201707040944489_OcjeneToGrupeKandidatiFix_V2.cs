namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OcjeneToGrupeKandidatiFix_V2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ocjene", "KandidatID", "dbo.Kandidati");
            DropIndex("dbo.Ocjene", new[] { "KandidatID" });
            DropColumn("dbo.Ocjene", "KandidatID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ocjene", "KandidatID", c => c.Int(nullable: false));
            CreateIndex("dbo.Ocjene", "KandidatID");
            AddForeignKey("dbo.Ocjene", "KandidatID", "dbo.Kandidati", "KandidatID");
        }
    }
}
