using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Base
{
    public class DbContextFactory : IDbContextFactory<PizzariaContext>
    {
        public PizzariaContext Create()
        {
            return new PizzariaContext();
        }
    }
}
