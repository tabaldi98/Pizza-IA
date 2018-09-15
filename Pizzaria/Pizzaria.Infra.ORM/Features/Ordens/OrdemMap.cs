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

            HasMany(f => f.Produtos).WithMany().Map(m =>
            {
                m.MapLeftKey("OrdemID"); m.MapRightKey("ProdutoID"); m.ToTable("Produtos_Ordem");
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
