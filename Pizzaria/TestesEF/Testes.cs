using NUnit.Framework;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Bebidas;
using Pizzaria.Infra.ORM.Features.Clientes;
using Pizzaria.Infra.ORM.Features.Ordens;
using Pizzaria.Infra.ORM.Features.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesEF.Base;

namespace TestesEF
{
    [TestFixture]
    public class Testes
    {
        [Test]
        public void SeedBanco()
        {
            var context = new PizzariaContext();
            BebidaRepositorio bebidaRepositorio = new BebidaRepositorio(context);
            context = new PizzariaContext();
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio(context);
            context = new PizzariaContext();
            OrdemRepositorio ordemRepositorio = new OrdemRepositorio(context);
            context = new PizzariaContext();
            PizzaRepositorio pizzaRepositorio = new PizzaRepositorio(context);

            //var ordem = ObjetoMae.GetOrdem();
            //ordemRepositorio.Add(ordem);

            var a = ordemRepositorio.GetAll();
            
        }
    }
}
