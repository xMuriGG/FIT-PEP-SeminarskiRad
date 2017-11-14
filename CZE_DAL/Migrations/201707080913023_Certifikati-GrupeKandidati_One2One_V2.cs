namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CertifikatiGrupeKandidati_One2One_V2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certifikati",
                c => new
                    {
                        CertifikatID = c.Int(nullable: false),
                        DatumOdobrenja = c.DateTime(nullable: false),
                        Uruceno = c.Boolean(nullable: false),
                        Biljeske = c.String(),
                        ZaposlenikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CertifikatID)
                .ForeignKey("dbo.GrupaKandidati", t => t.CertifikatID, cascadeDelete: true)
                .ForeignKey("dbo.Zaposlenici", t => t.ZaposlenikID)
                .Index(t => t.CertifikatID)
                .Index(t => t.ZaposlenikID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.Certifikati", "CertifikatID", "dbo.GrupaKandidati");
            DropIndex("dbo.Certifikati", new[] { "ZaposlenikID" });
            DropIndex("dbo.Certifikati", new[] { "CertifikatID" });
            DropTable("dbo.Certifikati");
        }
    }
}
