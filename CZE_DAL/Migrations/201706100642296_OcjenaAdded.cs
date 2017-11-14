namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OcjenaAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ocjene",
                c => new
                    {
                        OcjeneID = c.Int(nullable: false, identity: true),
                        KandidatID = c.Int(nullable: false),
                        KursTipID = c.Int(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        Ocjena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OcjeneID)
                .ForeignKey("dbo.Kandidati", t => t.KandidatID)
                .ForeignKey("dbo.KursTipovi", t => t.KursTipID)
                .Index(t => t.KandidatID)
                .Index(t => t.KursTipID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ocjene", "KursTipID", "dbo.KursTipovi");
            DropForeignKey("dbo.Ocjene", "KandidatID", "dbo.Kandidati");
            DropIndex("dbo.Ocjene", new[] { "KursTipID" });
            DropIndex("dbo.Ocjene", new[] { "KandidatID" });
            DropTable("dbo.Ocjene");
        }
    }
}
