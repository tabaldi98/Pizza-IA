using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Aplicacao.Features.Bebidas
{
    public class BebidaServico : IBebidaServico
    {
        private IBebidaRepositorio _bebidaRepositorio;
        private ISaborRepositorio _saborRepositorio;
        public BebidaServico(IBebidaRepositorio repositorio, ISaborRepositorio saborRepositorio)
        {
            this._bebidaRepositorio = repositorio;
            this._saborRepositorio = saborRepositorio;
        }

        public long Add(Bebida obj)
        {
            return _bebidaRepositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Bebida> objs)
        {

            foreach (var bebida in objs)
            {
                bebida.Validar();
                bebida.Sabor = _saborRepositorio.GetPorID(bebida.Sabor.ID);

            }

            var list = _bebidaRepositorio.AddLista(objs);

            List<long> listInt = new List<long>();

            foreach (var item in list)
            {
                listInt.Add(item.ID);
            }

            return listInt;
        }

        public bool Editar(Bebida obj)
        {
            return _bebidaRepositorio.Editar(obj);
        }

        public List<Bebida> GetAll()
        {
            return _bebidaRepositorio.GetAll();
        }

        public Bebida GetPorID(long id)
        {
            return _bebidaRepositorio.GetPorID(id);
        }

        public bool Remover(long id)
        {
            var objDb = _bebidaRepositorio.GetPorID(id) ?? throw new NotFoundException();
            return _bebidaRepositorio.Remover(objDb);
        }
    }
}
