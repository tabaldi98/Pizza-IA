namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sabores", "TipoSabor", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sabores", "TipoSabor");
        }
    }
}
