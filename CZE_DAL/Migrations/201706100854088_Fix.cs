namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.CertifikatID)
                .ForeignKey("dbo.GrupaKandidati", t => t.GrupaKandidatiID)
                .ForeignKey("dbo.Zaposlenici", t => t.ZaposlenikID)
                .Index(t => t.GrupaKandidatiID)
                .Index(t => t.ZaposlenikID);
            
            CreateTable(
                "dbo.GrupaKandidati",
                c => new
                    {
                        GrupaKandidatiID = c.Int(nullable: false, identity: true),
                        KandidatID = c.Int(nullable: false),
                        GrupaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrupaKandidatiID)
                .ForeignKey("dbo.Grupe", t => t.GrupaID)
                .ForeignKey("dbo.Kandidati", t => t.KandidatID)
                .Index(t => t.KandidatID)
                .Index(t => t.GrupaID);
            
            CreateTable(
                "dbo.Grupe",
                c => new
                    {
                        GrupaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        Pocetak = c.DateTime(nullable: false),
                        Kraj = c.DateTime(),
                        Aktivna = c.Boolean(nullable: false),
                        KursID = c.Int(nullable: false),
                        ZaposlenikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrupaID)
                .ForeignKey("dbo.Kurs", t => t.KursID)
                .ForeignKey("dbo.Zaposlenici", t => t.ZaposlenikID)
                .Index(t => t.KursID)
                .Index(t => t.ZaposlenikID);
            
            CreateTable(
                "dbo.UplateKandidata",
                c => new
                    {
                        UplataKandidataID = c.Int(nullable: false, identity: true),
                        Kolicina = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StatusUplate = c.Boolean(nullable: false),
                        RacunIzdat = c.Boolean(nullable: false),
                        Biljeske = c.String(),
                        DatumUplate = c.DateTime(nullable: false),
                        GrupaKandidatiID = c.Int(nullable: false),
                        ZaposlenikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UplataKandidataID)
                .ForeignKey("dbo.GrupaKandidati", t => t.GrupaKandidatiID)
                .ForeignKey("dbo.Zaposlenici", t => t.ZaposlenikID)
                .Index(t => t.GrupaKandidatiID)
                .Index(t => t.ZaposlenikID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UplateKandidata", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.UplateKandidata", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.Certifikati", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropForeignKey("dbo.GrupaKandidati", "KandidatID", "dbo.Kandidati");
            DropForeignKey("dbo.GrupaKandidati", "GrupaID", "dbo.Grupe");
            DropForeignKey("dbo.Grupe", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.Grupe", "KursID", "dbo.Kurs");
            DropIndex("dbo.UplateKandidata", new[] { "ZaposlenikID" });
            DropIndex("dbo.UplateKandidata", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.Grupe", new[] { "ZaposlenikID" });
            DropIndex("dbo.Grupe", new[] { "KursID" });
            DropIndex("dbo.GrupaKandidati", new[] { "GrupaID" });
            DropIndex("dbo.GrupaKandidati", new[] { "KandidatID" });
            DropIndex("dbo.Certifikati", new[] { "ZaposlenikID" });
            DropIndex("dbo.Certifikati", new[] { "GrupaKandidatiID" });
            DropTable("dbo.UplateKandidata");
            DropTable("dbo.Grupe");
            DropTable("dbo.GrupaKandidati");
            DropTable("dbo.Certifikati");
        }
    }
}
