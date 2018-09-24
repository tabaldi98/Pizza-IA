using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Pizzas;
using System;
using System.Collections.Generic;

namespace Pizzaria.Domain.Features.Ordem_de_Compra
{
    public class Ordem : Entidade
    {
        public Cliente Cliente { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public List<Bebida> Bebidas { get; set; }

        public DateTime DataPedido { get; set; }

        public double ValorEntrega { get; set; }

        public double ValorTotal { get { return CalcularTotal(); } }

        public TipoPagamento TipoPagamento { get; set; }
        public StatusOrdem StatusOrdem { get; set; }

        public Ordem()
        {
            if (Pizzas == null)
                Pizzas = new List<Pizza>();
            if (Bebidas == null)
                Bebidas = new List<Bebida>();

            DataPedido = DateTime.Now;
        }

        public void AdicionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }
        public void AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
        }

        public void RemoverTodosProdutos()
        {
            this.Pizzas = new List<Pizza>();
            this.Bebidas = new List<Bebida>();
        }

        private double CalcularTotal()
        {
            double valor = 0;

            foreach (var item in Pizzas)
            {
                valor += item.Valor;
            }

            foreach (var item in Bebidas)
            {
                valor += item.Valor;
            }

            if (ValorEntrega < 1)
                valor += ValorEntrega;

            return valor;
        }
    }
}
