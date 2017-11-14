namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OcjeneOpis_GrupaSlikeHCI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grupe", "Slika", c => c.Binary());
            AddColumn("dbo.Grupe", "SlikaThumb", c => c.Binary());
            AddColumn("dbo.Ocjene", "Opis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ocjene", "Opis");
            DropColumn("dbo.Grupe", "SlikaThumb");
            DropColumn("dbo.Grupe", "Slika");
        }
    }
}
