using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Sabores
{
    public class SaborMap : EntityTypeConfiguration<Sabor>
    {
        public SaborMap()
        {
            ToTable("Sabores");

            HasKey(x => x.ID);

            Property(x => x.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}
