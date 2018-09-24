using Pizzaria.Domain.Features.Enderecos;
using Postmon4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.CEP
{
    public static class ValidarCep
    {
        public static Endereco BuscarCep(string cep)
        {
            var endereco = new Endereco();

            if (string.IsNullOrEmpty(cep))
                return null;

            EnderecoInfo info = EncontrarEndereco.PorCEP(cep);
            endereco.Bairro = info.bairro;
            endereco.Cidade = info.cidade;
            endereco.Estado = info.estado;
            endereco.Rua = info.logradouro;

            return endereco;
        }
    }
}
