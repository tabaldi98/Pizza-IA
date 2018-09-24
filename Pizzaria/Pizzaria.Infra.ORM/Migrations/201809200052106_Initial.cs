namespace Pizzaria.Infra.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bebidas",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        TamanhoBebida = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        SaborID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sabores", t => t.SaborID, cascadeDelete: true)
                .Index(t => t.SaborID);
            
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
                        Email = c.String(nullable: false, maxLength: 100),
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
                        Bebida_ID = c.Long(),
                        ClientID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bebidas", t => t.Bebida_ID)
                .ForeignKey("dbo.Clientes", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.Bebida_ID)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        TamanhoPizza = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
                .ForeignKey("dbo.Pizzas", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.OrdemID)
                .Index(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos_Ordem", "ProdutoID", "dbo.Pizzas");
            DropForeignKey("dbo.Produtos_Ordem", "OrdemID", "dbo.Ordens");
            DropForeignKey("dbo.SaboresPizza", "SaborID", "dbo.Sabores");
            DropForeignKey("dbo.SaboresPizza", "PizzaID", "dbo.Pizzas");
            DropForeignKey("dbo.Ordens", "ClientID", "dbo.Clientes");
            DropForeignKey("dbo.Ordens", "Bebida_ID", "dbo.Bebidas");
            DropForeignKey("dbo.Clientes", "EnderecoID", "dbo.Endereco");
            DropForeignKey("dbo.Bebidas", "SaborID", "dbo.Sabores");
            DropIndex("dbo.Produtos_Ordem", new[] { "ProdutoID" });
            DropIndex("dbo.Produtos_Ordem", new[] { "OrdemID" });
            DropIndex("dbo.SaboresPizza", new[] { "SaborID" });
            DropIndex("dbo.SaboresPizza", new[] { "PizzaID" });
            DropIndex("dbo.Ordens", new[] { "ClientID" });
            DropIndex("dbo.Ordens", new[] { "Bebida_ID" });
            DropIndex("dbo.Clientes", new[] { "EnderecoID" });
            DropIndex("dbo.Bebidas", new[] { "SaborID" });
            DropTable("dbo.Produtos_Ordem");
            DropTable("dbo.SaboresPizza");
            DropTable("dbo.Pizzas");
            DropTable("dbo.Ordens");
            DropTable("dbo.Endereco");
            DropTable("dbo.Clientes");
            DropTable("dbo.Sabores");
            DropTable("dbo.Bebidas");
        }
    }
}
