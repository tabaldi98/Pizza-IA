namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ordens", "StatusOrdem", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ordens", "StatusOrdem");
        }
    }
}
