using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Features.Enderecos;

namespace Pizzaria.Aplicacao.Features.Enderecos
{
    public class EnderecoServico : IEnderecoServico
    {
        private IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoServico(IEnderecoRepositorio enderecoRepositorio)
        {
            this._enderecoRepositorio = enderecoRepositorio;
        }
        public long Add(Endereco obj)
        {
            return _enderecoRepositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Endereco> objs)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Endereco obj)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> GetAll()
        {
            return _enderecoRepositorio.GetAll();
        }

        public Endereco GetPorID(long id)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> ObterPorCidade(string cidade)
        {
            return _enderecoRepositorio.ObterPorCidade(cidade);
        }

        public bool Remover(long id)
        {
            throw new NotImplementedException();
        }
    }
}
