using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Ordem_de_Compra;

namespace Pizzaria.Aplicacao.Features.Pedidos
{
    public class PedidoServico : IPedidoServico
    {
        private IOrdemRepositorio _ordemRepositorio;

        public PedidoServico(IOrdemRepositorio ordemRepositorio)
        {
            this._ordemRepositorio = ordemRepositorio;
        }
        public long Add(Ordem obj)
        {
            return _ordemRepositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Ordem> objs)
        {
            var list = _ordemRepositorio.AddLista(objs);

            List<long> listInt = new List<long>();

            foreach (var item in list)
            {
                listInt.Add(item.ID);
            }

            return listInt;
        }

        public bool Editar(Ordem obj)
        {
            return _ordemRepositorio.Editar(obj);
        }

        public List<Ordem> GetAll()
        {
            return _ordemRepositorio.GetAll();
        }

        public Ordem GetPorID(long id)
        {
            return _ordemRepositorio.GetPorID(id);
        }

        public bool Remover(long id)
        {
            var objDb = _ordemRepositorio.GetPorID(id) ?? throw new NotFoundException();
            return _ordemRepositorio.Remover(objDb);
        }
    }
}
