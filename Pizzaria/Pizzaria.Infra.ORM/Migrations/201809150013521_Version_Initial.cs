namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version_Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sabores",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Numero = c.String(nullable: false, maxLength: 100),
                        EnderecoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Endereco", t => t.EnderecoID, cascadeDelete: true)
                .Index(t => t.EnderecoID);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CEP = c.String(),
                        Rua = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Bairro = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ordens",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        ValorEntrega = c.Double(),
                        ClientID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clientes", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.SaboresPizza",
                c => new
                    {
                        PizzaID = c.Long(nullable: false),
                        SaborID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.PizzaID, t.SaborID })
                .ForeignKey("dbo.Pizzas", t => t.PizzaID, cascadeDelete: true)
                .ForeignKey("dbo.Sabores", t => t.SaborID, cascadeDelete: true)
                .Index(t => t.PizzaID)
                .Index(t => t.SaborID);
            
            CreateTable(
                "dbo.Produtos_Ordem",
                c => new
                    {
                        OrdemID = c.Long(nullable: false),
                        ProdutoID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrdemID, t.ProdutoID })
                .ForeignKey("dbo.Ordens", t => t.OrdemID, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.OrdemID)
                .Index(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Bebidas",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        SaborID = c.Long(nullable: false),
                        TamanhoBebida = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Produto", t => t.ID)
                .ForeignKey("dbo.Sabores", t => t.SaborID, cascadeDelete: true)
                .Index(t => t.ID)
                .Index(t => t.SaborID);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        ID = c.Long(nullable: false),
                        TamanhoPizza = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Produto", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "ID", "dbo.Produto");
            DropForeignKey("dbo.Bebidas", "SaborID", "dbo.Sabores");
            DropForeignKey("dbo.Bebidas", "ID", "dbo.Produto");
            DropForeignKey("dbo.Produtos_Ordem", "ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Produtos_Ordem", "OrdemID", "dbo.Ordens");
            DropForeignKey("dbo.SaboresPizza", "SaborID", "dbo.Sabores");
            DropForeignKey("dbo.SaboresPizza", "PizzaID", "dbo.Pizzas");
            DropForeignKey("dbo.Ordens", "ClientID", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "EnderecoID", "dbo.Endereco");
            DropIndex("dbo.Pizzas", new[] { "ID" });
            DropIndex("dbo.Bebidas", new[] { "SaborID" });
            DropIndex("dbo.Bebidas", new[] { "ID" });
            DropIndex("dbo.Produtos_Ordem", new[] { "ProdutoID" });
            DropIndex("dbo.Produtos_Ordem", new[] { "OrdemID" });
            DropIndex("dbo.SaboresPizza", new[] { "SaborID" });
            DropIndex("dbo.SaboresPizza", new[] { "PizzaID" });
            DropIndex("dbo.Ordens", new[] { "ClientID" });
            DropIndex("dbo.Clientes", new[] { "EnderecoID" });
            DropTable("dbo.Pizzas");
            DropTable("dbo.Bebidas");
            DropTable("dbo.Produtos_Ordem");
            DropTable("dbo.SaboresPizza");
            DropTable("dbo.Ordens");
            DropTable("dbo.Endereco");
            DropTable("dbo.Clientes");
            DropTable("dbo.Sabores");
            DropTable("dbo.Produto");
        }
    }
}
