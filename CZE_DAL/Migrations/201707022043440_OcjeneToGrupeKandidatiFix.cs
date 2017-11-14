namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OcjeneToGrupeKandidatiFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ocjene", "KursID", "dbo.Kurs");
            DropIndex("dbo.Ocjene", new[] { "KursID" });
            AddColumn("dbo.Ocjene", "GrupaKandidatiID", c => c.Int(nullable: false));
            CreateIndex("dbo.Ocjene", "GrupaKandidatiID");
            AddForeignKey("dbo.Ocjene", "GrupaKandidatiID", "dbo.GrupaKandidati", "GrupaKandidatiID");
            DropColumn("dbo.Ocjene", "KursID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ocjene", "KursID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ocjene", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropIndex("dbo.Ocjene", new[] { "GrupaKandidatiID" });
            DropColumn("dbo.Ocjene", "GrupaKandidatiID");
            CreateIndex("dbo.Ocjene", "KursID");
            AddForeignKey("dbo.Ocjene", "KursID", "dbo.Kurs", "KursID");
        }
    }
}
