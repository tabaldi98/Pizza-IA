using Pizzaria.Domain.Features.Pizzas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Pizzas
{
    public class PizzaMap : EntityTypeConfiguration<Pizza>
    {
        public PizzaMap()
        {
            ToTable("Pizzas");

            HasKey(x => x.ID);

            Property(x => x.Valor).IsRequired();
            Property(x => x.TamanhoPizza).IsRequired();

            HasMany(f => f.Sabores).WithMany().Map(m =>
            {
                m.MapLeftKey("PizzaID"); m.MapRightKey("SaborID"); m.ToTable("SaboresPizza");
            });

        }
    }
}
