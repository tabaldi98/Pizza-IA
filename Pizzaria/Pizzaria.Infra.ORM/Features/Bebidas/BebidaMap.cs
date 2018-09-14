using Pizzaria.Domain.Features.Bebidas;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Bebidas
{
    public class BebidaMap : EntityTypeConfiguration<Bebida>
    {
        public BebidaMap()
        {
            ToTable("Bebidas");

            HasKey(x => x.ID);

            HasRequired(x => x.Sabor)
              .WithMany()
              .Map(m => m.MapKey("SaborID"))
              .WillCascadeOnDelete(true);

            Property(x => x.TamanhoBebida).IsRequired();
            Property(x => x.Valor).IsRequired();
        }
    }
}
