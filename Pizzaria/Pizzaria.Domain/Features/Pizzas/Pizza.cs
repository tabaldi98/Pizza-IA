using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Produtos;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Pizzas
{
    public class Pizza : Produto
    {
        public TamanhoPizza TamanhoPizza { get; set; }

        public List<Sabor> Sabores { get; set; }

        public Pizza()
        {
            Sabores = new List<Sabor>();
        }

        public void AdicionarSabor(Sabor sabor)
        {
            this.Sabores.Add(sabor);
        }

        public void Validar()
        {
            if (Sabores.Count > 4)
                throw new Exception("A pizza pode ter no máximo 4 sabores");
            if (Sabores.Count == 3)
                throw new Exception("A pizza não pode ter 3 sabores");
        }

    }
}
