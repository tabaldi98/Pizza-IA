using Pizzaria.Aplicacao.Base;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Aplicacao.Features.Clientes
{
    public interface IClienteServico : IServico<Cliente>
    {
        List<Cliente> GetPorTelefone(string telefone);

    }
}
