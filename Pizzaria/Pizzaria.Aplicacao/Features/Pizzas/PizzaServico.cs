using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using System.Collections.Generic;

namespace Pizzaria.Aplicacao.Features.Pizzas
{
    public class PizzaServico : IPizzaServico

    {
        private IPizzaRepositorio _pizzaRepositorio;
        private ISaborRepositorio _saborRepositorio;

        public PizzaServico(IPizzaRepositorio repositorio, ISaborRepositorio saborRepositorio)
        {
            _pizzaRepositorio = repositorio;
            _saborRepositorio = saborRepositorio;
        }

        public long Add(Pizza obj)
        {
            return _pizzaRepositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Pizza> objs)
        {
            var sabores = new List<Sabor>();

            foreach (var pizza in objs)
            {
                pizza.Validar();

                foreach (var sabor in pizza.Sabores)
                {
                    sabores.Add(_saborRepositorio.GetPorID(sabor.ID));
                }

                pizza.RemoverTodosSabores();
                pizza.Sabores = sabores;
            }


            var list = _pizzaRepositorio.AddLista(objs);

            List<long> listInt = new List<long>();

            foreach (var item in list)
            {
                listInt.Add(item.ID);
            }

            return listInt;
        }

        public bool Editar(Pizza obj)
        {
            return _pizzaRepositorio.Editar(obj);
        }

        public List<Pizza> GetAll()
        {
            return _pizzaRepositorio.GetAll();
        }

        public Pizza GetPorID(long id)
        {
            return _pizzaRepositorio.GetPorID(id);
        }

        public bool Remover(long id)
        {
            var objDb = _pizzaRepositorio.GetPorID(id) ?? throw new NotFoundException();
            return _pizzaRepositorio.Remover(objDb);
        }
    }
}
