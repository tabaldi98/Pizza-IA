namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtos_Ordem", newName: "Pizza_Ordem");
            DropForeignKey("dbo.Ordens", "Bebida_ID", "dbo.Bebidas");
            DropIndex("dbo.Ordens", new[] { "Bebida_ID" });
            RenameColumn(table: "dbo.Pizza_Ordem", name: "ProdutoID", newName: "PizzaID");
            RenameIndex(table: "dbo.Pizza_Ordem", name: "IX_ProdutoID", newName: "IX_PizzaID");
            CreateTable(
                "dbo.Bebida_Ordem",
                c => new
                    {
                        OrdemID = c.Long(nullable: false),
                        BebidaID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrdemID, t.BebidaID })
                .ForeignKey("dbo.Ordens", t => t.OrdemID, cascadeDelete: true)
                .ForeignKey("dbo.Bebidas", t => t.BebidaID, cascadeDelete: true)
                .Index(t => t.OrdemID)
                .Index(t => t.BebidaID);
            
            DropColumn("dbo.Ordens", "Bebida_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ordens", "Bebida_ID", c => c.Long());
            DropForeignKey("dbo.Bebida_Ordem", "BebidaID", "dbo.Bebidas");
            DropForeignKey("dbo.Bebida_Ordem", "OrdemID", "dbo.Ordens");
            DropIndex("dbo.Bebida_Ordem", new[] { "BebidaID" });
            DropIndex("dbo.Bebida_Ordem", new[] { "OrdemID" });
            DropTable("dbo.Bebida_Ordem");
            RenameIndex(table: "dbo.Pizza_Ordem", name: "IX_PizzaID", newName: "IX_ProdutoID");
            RenameColumn(table: "dbo.Pizza_Ordem", name: "PizzaID", newName: "ProdutoID");
            CreateIndex("dbo.Ordens", "Bebida_ID");
            AddForeignKey("dbo.Ordens", "Bebida_ID", "dbo.Bebidas", "ID");
            RenameTable(name: "dbo.Pizza_Ordem", newName: "Produtos_Ordem");
        }
    }
}
