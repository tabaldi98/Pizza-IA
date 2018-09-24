using Pizzaria.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Clientes
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        List<Cliente> GetPorTelefone(string telefone);

    }
}
