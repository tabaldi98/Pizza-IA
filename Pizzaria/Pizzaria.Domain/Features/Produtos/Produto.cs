using Pizzaria.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Produtos
{
    public abstract class Produto : Entidade
    {
        public double Valor { get; set; }
    }
}
