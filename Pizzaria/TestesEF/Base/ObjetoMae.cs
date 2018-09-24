using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Enderecos;
using Pizzaria.Domain.Features.Ordem_de_Compra;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesEF.Base
{
    public static class ObjetoMae
    {
        public static Bebida GetBebida()
        {
            Bebida bebida = new Bebida();

            bebida.ID = 1;
            bebida.TamanhoBebida = TamanhoBebida.Garrafa;
            bebida.Valor = 14;
            bebida.Sabor = new Sabor()
            {
                ID = 1,
                Descricao = "Coca-Cola",
            };

            return bebida;
        }

        public static Cliente GetCliente()
        {
            Cliente cliente = new Cliente();
            cliente.ID = 1;
            cliente.Nome = "Jose das coves";
            cliente.Numero = "5464654654564";
            cliente.Email = "aasjiajs@haas.com";
            cliente.Endereco = new Endereco()
            {
                ID = 1,
                Bairro = "Bairro",
                CEP = "CEP",
                Cidade = "Cidade",
                Estado = "Estado",
                Rua = "Rua",
                Numero = 10,
            };
            return cliente;
        }

        public static Ordem GetOrdem()
        {
            Ordem ordem = new Ordem();

            ordem.Cliente = new Cliente()
            {
                ID = 1,
                Nome = "Jose das coves",
                Numero = "5464654654564",
                Email = "aasjiajs@haas.com",
                Endereco = new Endereco()
                {
                    ID = 1,
                    Bairro = "Bairro",
                    CEP = "CEP",
                    Cidade = "Cidade",
                    Estado = "Estado",
                    Rua = "Rua",
                    Numero = 10,
                },

            };

            ordem.ID = 1;
            ordem.ValorEntrega = 5;

            var pizza = new Pizza()
            {
                ID = 1,
                Sabores = new List<Sabor>()
                {
                    new Sabor()
                    {
                        ID = 1,
                        Descricao = "Calabresa",
                    },
                },
                TamanhoPizza = TamanhoPizza.ExtraGigante,
                Valor = 100,
            };

            ordem.AdicionarPizza(pizza);

            var bebida = new Bebida()
            {
                ID = 1,
                TamanhoBebida = TamanhoBebida.Garrafa,
                Valor = 14,
                Sabor = new Sabor()
                {
                    ID = 1,
                    Descricao = "Coca-Cola",
                },
            };

            ordem.AdicionarBebida(bebida);
            return ordem;
        }

        public static Pizza GetPizza()
        {
            return new Pizza()
            {
                ID = 1,
                Sabores = new List<Sabor>()
                {
                    new Sabor()
                    {
                        ID = 1,
                        Descricao = "Calabresa",
                    },
                },
                TamanhoPizza = TamanhoPizza.ExtraGigante,
                Valor = 100,
            };
        }

    }
}
