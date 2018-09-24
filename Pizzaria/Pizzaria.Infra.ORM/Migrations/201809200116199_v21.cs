namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ordens", "TipoPagamento", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ordens", "TipoPagamento");
        }
    }
}
