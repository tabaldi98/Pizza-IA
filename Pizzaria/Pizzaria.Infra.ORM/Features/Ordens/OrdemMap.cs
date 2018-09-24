using Pizzaria.Domain.Features.Ordem_de_Compra;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Ordens
{
    public class OrdemMap : EntityTypeConfiguration<Ordem>
    {
        public OrdemMap()
        {
            ToTable("Ordens");

            HasKey(x => x.ID);

            HasMany(f => f.Pizzas).WithMany().Map(m =>
            {
                m.MapLeftKey("OrdemID"); m.MapRightKey("PizzaID"); m.ToTable("Pizza_Ordem");
            });
            HasMany(f => f.Bebidas).WithMany().Map(m =>
            {
                m.MapLeftKey("OrdemID"); m.MapRightKey("BebidaID"); m.ToTable("Bebida_Ordem");
            });

            HasRequired(c => c.Cliente)
               .WithMany()
               .Map(m => m.MapKey("ClientID"))
               .WillCascadeOnDelete(true);

            Property(x => x.ValorEntrega).IsOptional();
            Property(x => x.DataPedido).IsRequired();

            Ignore(x => x.ValorTotal);

        }
    }
}
