using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Sabores
{
    public interface ISaborRepositorio : IRepositorio<Sabor>
    {
        List<Sabor> GetAllPorTipo(TipoSabor tipoSabor);
        List<Sabor> ObterPorDescricao(string sabor, TipoSabor tipoSabor);
    }
}
