using Pizzaria.Domain.Features.Produtos;
using Pizzaria.Domain.Features.Sabores;

namespace Pizzaria.Domain.Features.Bebidas
{
    public class Bebida : Produto
    {
        public TamanhoBebida TamanhoBebida { get; set; }
        public Sabor Sabor { get; set; }

        public Bebida()
        {
            if (Sabor == null)
                Sabor = new Sabor();
        }
        public override string ToString()
        {
            return TamanhoBebida.ToString() + " - " + Sabor.Descricao;
        }
    }
}
