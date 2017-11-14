namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CascadeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kandidati", "KandidatID", "dbo.Osobe");
            DropForeignKey("dbo.Zaposlenici", "ZaposlenikID", "dbo.Osobe");
            AddForeignKey("dbo.Kandidati", "KandidatID", "dbo.Osobe", "OsobaID", cascadeDelete: true);
            AddForeignKey("dbo.Zaposlenici", "ZaposlenikID", "dbo.Osobe", "OsobaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zaposlenici", "ZaposlenikID", "dbo.Osobe");
            DropForeignKey("dbo.Kandidati", "KandidatID", "dbo.Osobe");
            AddForeignKey("dbo.Zaposlenici", "ZaposlenikID", "dbo.Osobe", "OsobaID");
            AddForeignKey("dbo.Kandidati", "KandidatID", "dbo.Osobe", "OsobaID");
        }
    }
}
