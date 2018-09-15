using Pizzaria.Domain.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Clientes
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            int maxLength = 100;

            ToTable("Clientes");

            HasKey(x => x.ID);

            HasRequired(x => x.Endereco)
            .WithMany()
            .Map(m => m.MapKey("EnderecoID"))
            .WillCascadeOnDelete(true);

            Property(x => x.Nome).HasMaxLength(maxLength).IsRequired();
            Property(x => x.Numero).HasMaxLength(maxLength).IsRequired();
            Property(x => x.Numero).HasMaxLength(maxLength).IsRequired();
            Property(x => x.Email).HasMaxLength(maxLength).IsRequired();

            Ignore(x => x.Pedidos);
        }

    }
}
