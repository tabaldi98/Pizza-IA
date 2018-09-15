using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Ordem_de_Compra
{
    public class Ordem : Entidade
    {
        public Cliente Cliente { get; set; }

        public List<Produto> Produtos { get; set; }

        public DateTime DataPedido { get; set; }

        public double ValorEntrega { get; set; }

        public double ValorTotal { get { return CalcularTotal(); } }

        public Ordem()
        {
            if (Produtos == null)
                Produtos = new List<Produto>();
            DataPedido = DateTime.Now;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        private double CalcularTotal()
        {
            double valor = 0;

            foreach (var item in Produtos)
            {
                valor += item.Valor;
            }

            if (ValorEntrega < 1)
                valor += ValorEntrega;

            return valor;
        }
    }
}
