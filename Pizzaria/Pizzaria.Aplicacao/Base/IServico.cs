using Pizzaria.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Aplicacao.Base
{
    public interface IServico<T> where T : Entidade
    {
        long Add(T obj);
        List<long> AddLista(List<T> objs);

        bool Editar(T obj);

        bool Remover(long id);

        T GetPorID(long id);

        List<T> GetAll();
    }
}
