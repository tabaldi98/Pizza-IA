using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Base
{
    public interface IRepositorio<T> where T : Entidade
    {
        T Add(T obj);

        List<T> AddLista(List<T> objs);

        bool Editar(T obj);

        bool Remover(T obj);

        T GetPorID(long id);

        List<T> GetAll();
    }
}
