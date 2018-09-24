using Pizzaria.Aplicacao.Base;
using Pizzaria.Domain.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Aplicacao.Features.Enderecos
{
    public interface IEnderecoServico : IServico<Endereco>
    {
        List<Endereco> ObterPorCidade(string cidade);
    }
}
