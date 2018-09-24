using Pizzaria.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Enderecos
{
    public interface IEnderecoRepositorio : IRepositorio<Endereco>
    {
        List<Endereco> ObterPorCidade(string cidade);
    }
}
