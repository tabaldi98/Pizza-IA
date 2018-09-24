using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;

namespace Pizzaria.Aplicacao.Features.Sabores
{
    public class SaborServico : ISaborServico
    {
        private ISaborRepositorio _repositorio;

        public SaborServico(ISaborRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        public long Add(Sabor obj)
        {
            return _repositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Sabor> objs)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Sabor obj)
        {
            throw new NotImplementedException();
        }

        public List<Sabor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Sabor> GetAllPorTipo(TipoSabor tipoSabor)
        {
            return _repositorio.GetAllPorTipo(tipoSabor);

        }

        public Sabor GetPorID(long id)
        {
            throw new NotImplementedException();
        }

        public List<Sabor> ObterPorDescricao(string sabor, TipoSabor tipoSabor)
        {
            return _repositorio.ObterPorDescricao(sabor, tipoSabor);
        }

        public bool Remover(long id)
        {
            throw new NotImplementedException();
        }
    }
}
