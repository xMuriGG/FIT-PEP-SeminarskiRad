namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixInitial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kurs", "Grupa_GrupaID", "dbo.Grupe");
            DropForeignKey("dbo.Grupe", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.GrupaKandidati", "GrupaID", "dbo.Grupe");
            DropForeignKey("dbo.GrupaKandidati", "KandidatID", "dbo.Kandidati");
            DropForeignKey("dbo.Certifikati", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici");
            DropForeignKey("dbo.UplateKandidata", "GrupaKandidatiID", "dbo.GrupaKandidati");
            DropForeignKey("dbo.UplateKandidata", "ZaposlenikID", "dbo.Zaposlenici");
            DropIndex("dbo.Certifikati", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.Certifikati", new[] { "ZaposlenikID" });
            DropIndex("dbo.GrupaKandidati", new[] { "KandidatID" });
            DropIndex("dbo.GrupaKandidati", new[] { "GrupaID" });
            DropIndex("dbo.Grupe", new[] { "ZaposlenikID" });
            DropIndex("dbo.Kurs", new[] { "Grupa_GrupaID" });
            DropIndex("dbo.UplateKandidata", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.UplateKandidata", new[] { "ZaposlenikID" });
            DropColumn("dbo.Kurs", "Grupa_GrupaID");
            DropTable("dbo.Certifikati");
            DropTable("dbo.GrupaKandidati");
            DropTable("dbo.Grupe");
            DropTable("dbo.UplateKandidata");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.UplataKandidataID);
            
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
                .PrimaryKey(t => t.GrupaID);
            
            CreateTable(
                "dbo.GrupaKandidati",
                c => new
                    {
                        GrupaKandidatiID = c.Int(nullable: false, identity: true),
                        KandidatID = c.Int(nullable: false),
                        GrupaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GrupaKandidatiID);
            
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
            
            AddColumn("dbo.Kurs", "Grupa_GrupaID", c => c.Int());
            CreateIndex("dbo.UplateKandidata", "ZaposlenikID");
            CreateIndex("dbo.UplateKandidata", "GrupaKandidatiID");
            CreateIndex("dbo.Kurs", "Grupa_GrupaID");
            CreateIndex("dbo.Grupe", "ZaposlenikID");
            CreateIndex("dbo.GrupaKandidati", "GrupaID");
            CreateIndex("dbo.GrupaKandidati", "KandidatID");
            CreateIndex("dbo.Certifikati", "ZaposlenikID");
            CreateIndex("dbo.Certifikati", "GrupaKandidatiID");
            AddForeignKey("dbo.UplateKandidata", "ZaposlenikID", "dbo.Zaposlenici", "ZaposlenikID");
            AddForeignKey("dbo.UplateKandidata", "GrupaKandidatiID", "dbo.GrupaKandidati", "GrupaKandidatiID");
            AddForeignKey("dbo.Certifikati", "ZaposlenikID", "dbo.Zaposlenici", "ZaposlenikID");
            AddForeignKey("dbo.Certifikati", "GrupaKandidatiID", "dbo.GrupaKandidati", "GrupaKandidatiID");
            AddForeignKey("dbo.GrupaKandidati", "KandidatID", "dbo.Kandidati", "KandidatID");
            AddForeignKey("dbo.GrupaKandidati", "GrupaID", "dbo.Grupe", "GrupaID");
            AddForeignKey("dbo.Grupe", "ZaposlenikID", "dbo.Zaposlenici", "ZaposlenikID");
            AddForeignKey("dbo.Kurs", "Grupa_GrupaID", "dbo.Grupe", "GrupaID");
        }
    }
}
