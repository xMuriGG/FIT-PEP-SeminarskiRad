namespace CZE_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KorisnickiNalogLozinkaUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KorisnickiNalozi", "LozinkaHash", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.KorisnickiNalozi", "LozinkaSalt", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.KorisnickiNalozi", "Lozinka");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KorisnickiNalozi", "Lozinka", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.KorisnickiNalozi", "LozinkaSalt");
            DropColumn("dbo.KorisnickiNalozi", "LozinkaHash");
        }
    }
}
