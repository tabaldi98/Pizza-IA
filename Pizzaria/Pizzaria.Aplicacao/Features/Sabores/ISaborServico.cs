using Pizzaria.Aplicacao.Base;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Aplicacao.Features.Sabores
{
    public interface ISaborServico : IServico<Sabor>
    {
        List<Sabor> ObterPorDescricao(string sabor, TipoSabor tipoSabor);
        List<Sabor> GetAllPorTipo(TipoSabor tipoSabor);
    }
}
