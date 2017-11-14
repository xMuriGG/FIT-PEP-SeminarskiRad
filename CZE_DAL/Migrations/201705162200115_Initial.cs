namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrojeviTelefona",
                c => new
                    {
                        BrojTelefonaID = c.Int(nullable: false, identity: true),
                        Broj = c.String(nullable: false, maxLength: 15),
                        TipTelefona = c.Int(nullable: false),
                        OsobaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BrojTelefonaID)
                .ForeignKey("dbo.Osobe", t => t.OsobaID, cascadeDelete: true)
                .Index(t => t.OsobaID);
            
            CreateTable(
                "dbo.Osobe",
                c => new
                    {
                        OsobaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 50),
                        Prezime = c.String(nullable: false, maxLength: 50),
                        DatumRodjenja = c.DateTime(nullable: false),
                        Spol = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100),
                        Adresa = c.String(nullable: false, maxLength: 100),
                        GradID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OsobaID)
                .ForeignKey("dbo.Gradovi", t => t.GradID)
                .Index(t => t.GradID);
            
            CreateTable(
                "dbo.Kandidati",
                c => new
                    {
                        KandidatID = c.Int(nullable: false),
                        DatumUpisa = c.DateTime(nullable: false),
                        Biljeske = c.String(),
                    })
                .PrimaryKey(t => t.KandidatID)
                .ForeignKey("dbo.Osobe", t => t.KandidatID)
                .Index(t => t.KandidatID);
            
            CreateTable(
                "dbo.KorisnickiNalozi",
                c => new
                    {
                        KorisnickiNalogID = c.Int(nullable: false),
                        KorisnickoIme = c.String(nullable: false, maxLength: 50),
                        Lozinka = c.String(nullable: false, maxLength: 50),
                        Aktivan = c.Boolean(nullable: false),
                        UlogaKorisnika = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KorisnickiNalogID)
                .ForeignKey("dbo.Osobe", t => t.KorisnickiNalogID)
                .Index(t => t.KorisnickiNalogID);
            
            CreateTable(
                "dbo.Gradovi",
                c => new
                    {
                        GradID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.GradID);
            
            CreateTable(
                "dbo.Zaposlenici",
                c => new
                    {
                        ZaposlenikID = c.Int(nullable: false),
                        StepenObrazovanja = c.Int(nullable: false),
                        BrojRadneKnjizice = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ZaposlenikID)
                .ForeignKey("dbo.Osobe", t => t.ZaposlenikID)
                .Index(t => t.ZaposlenikID);
            
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
                .ForeignKey("dbo.Zaposlenici", t => t.ZaposlenikID)
                .Index(t => t.ZaposlenikID);
            
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        KursID = c.Int(nullable: false, identity: true),
                        KursTipID = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        Opis = c.String(),
                        Grupa_GrupaID = c.Int(),
                    })
                .PrimaryKey(t => t.KursID)
                .ForeignKey("dbo.KursTipovi", t => t.KursTipID)
                .ForeignKey("dbo.Grupe", t => t.Grupa_GrupaID)
                .Index(t => t.KursTipID)
                .Index(t => t.Grupa_GrupaID);
            
            CreateTable(
                "dbo.KursTipovi",
                c => new
                    {
                        KursTipID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 50),
                        Trajanje = c.Int(nullable: false),
                        Cijena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Opis = c.String(nullable: false, maxLength: 1000),
                        KursKategorijaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KursTipID)
                .ForeignKey("dbo.KursKategorijas", t => t.KursKategorijaID)
                .Index(t => t.KursKategorijaID);
            
            CreateTable(
                "dbo.KursKategorijas",
                c => new
                    {
                        KursKategorijaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.KursKategorijaID);
            
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
            DropForeignKey("dbo.Kurs", "Grupa_GrupaID", "dbo.Grupe");
            DropForeignKey("dbo.Kurs", "KursTipID", "dbo.KursTipovi");
            DropForeignKey("dbo.KursTipovi", "KursKategorijaID", "dbo.KursKategorijas");
            DropForeignKey("dbo.Zaposlenici", "ZaposlenikID", "dbo.Osobe");
            DropForeignKey("dbo.Osobe", "GradID", "dbo.Gradovi");
            DropForeignKey("dbo.KorisnickiNalozi", "KorisnickiNalogID", "dbo.Osobe");
            DropForeignKey("dbo.Kandidati", "KandidatID", "dbo.Osobe");
            DropForeignKey("dbo.BrojeviTelefona", "OsobaID", "dbo.Osobe");
            DropIndex("dbo.UplateKandidata", new[] { "ZaposlenikID" });
            DropIndex("dbo.UplateKandidata", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.KursTipovi", new[] { "KursKategorijaID" });
            DropIndex("dbo.Kurs", new[] { "Grupa_GrupaID" });
            DropIndex("dbo.Kurs", new[] { "KursTipID" });
            DropIndex("dbo.Grupe", new[] { "ZaposlenikID" });
            DropIndex("dbo.GrupaKandidati", new[] { "GrupaID" });
            DropIndex("dbo.GrupaKandidati", new[] { "KandidatID" });
            DropIndex("dbo.Certifikati", new[] { "ZaposlenikID" });
            DropIndex("dbo.Certifikati", new[] { "GrupaKandidatiID" });
            DropIndex("dbo.Zaposlenici", new[] { "ZaposlenikID" });
            DropIndex("dbo.KorisnickiNalozi", new[] { "KorisnickiNalogID" });
            DropIndex("dbo.Kandidati", new[] { "KandidatID" });
            DropIndex("dbo.Osobe", new[] { "GradID" });
            DropIndex("dbo.BrojeviTelefona", new[] { "OsobaID" });
            DropTable("dbo.UplateKandidata");
            DropTable("dbo.KursKategorijas");
            DropTable("dbo.KursTipovi");
            DropTable("dbo.Kurs");
            DropTable("dbo.Grupe");
            DropTable("dbo.GrupaKandidati");
            DropTable("dbo.Certifikati");
            DropTable("dbo.Zaposlenici");
            DropTable("dbo.Gradovi");
            DropTable("dbo.KorisnickiNalozi");
            DropTable("dbo.Kandidati");
            DropTable("dbo.Osobe");
            DropTable("dbo.BrojeviTelefona");
        }
    }
}
