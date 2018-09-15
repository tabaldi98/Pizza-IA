using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Ordem_de_Compra;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Base
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(string connection = "Name=Pizzaria") : base(connection)
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = true;
        }

        public PizzariaContext(DbConnection connection) : base(connection, true) { }

        public DbSet<Bebida> Bebida { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ordem> Ordem { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Sabor> Sabor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
