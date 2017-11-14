namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CertifikatiGrupeKandidati_One2One_V1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Certifikati", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici");
            DropIndex("dbo.Certifikati", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.Certifikati", new[] { "ZaposlenikID" });
            DropTable("dbo.Certifikati");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Certifikati",
                c => new
                    {
                        CertifikatID = c.Int(nullable: false, identity: true),
                        GrupaKandidatiID = c.Int(nullable: false),
                        DatumOdobrenja = c.DateTime(nullable: false),
                        Uruceno = c.Boolean(nullable: false),
                        Biljeske = c.String(),
                        ZaposlenikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CertifikatID);
            
            CreateIndex("dbo.Certifikati", "ZaposlenikID");
            CreateIndex("dbo.Certifikati", "GrupaKandidatiID");
            AddForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici", "ZaposlenikID");
            AddForeignKey("dbo.Certifikati", "GrupaKandidatiID", "dbo.GrupaKandidati", "GrupaKandidatiID");
        }
    }
}
