namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OcjeneFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ocjene", "KursTipID", "dbo.KursTipovi");
            DropIndex("dbo.Ocjene", new[] { "KursTipID" });
            AddColumn("dbo.Ocjene", "KursID", c => c.Int(nullable: false));
            CreateIndex("dbo.Ocjene", "KursID");
            AddForeignKey("dbo.Ocjene", "KursID", "dbo.Kurs", "KursID");
            DropColumn("dbo.Ocjene", "KursTipID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ocjene", "KursTipID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ocjene", "KursID", "dbo.Kurs");
            DropIndex("dbo.Ocjene", new[] { "KursID" });
            DropColumn("dbo.Ocjene", "KursID");
            CreateIndex("dbo.Ocjene", "KursTipID");
            AddForeignKey("dbo.Ocjene", "KursTipID", "dbo.KursTipovi", "KursTipID");
        }
    }
}
