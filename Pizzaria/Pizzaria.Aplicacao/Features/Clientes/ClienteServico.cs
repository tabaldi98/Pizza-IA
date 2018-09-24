using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Clientes;

namespace Pizzaria.Aplicacao.Features.Clientes
{
    public class ClienteServico : IClienteServico
    {
        private IClienteRepositorio _repositorio;

        public ClienteServico(IClienteRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        public long Add(Cliente obj)
        {
            return _repositorio.Add(obj).ID;
        }

        public List<long> AddLista(List<Cliente> objs)
        {
            var list = _repositorio.AddLista(objs);

            List<long> listInt = new List<long>();

            foreach (var item in list)
            {
                listInt.Add(item.ID);
            }

            return listInt;
        }

        public bool Editar(Cliente obj)
        {
            var objDb = _repositorio.GetPorID(obj.ID) ?? throw new NotFoundException();

            objDb.Email = obj.Email;
            objDb.Endereco.Bairro = obj.Endereco.Bairro;
            objDb.Endereco.Cidade = obj.Endereco.Cidade;
            objDb.Endereco.Estado = obj.Endereco.Estado;
            objDb.Endereco.CEP = obj.Endereco.CEP;
            objDb.Endereco.Numero = obj.Endereco.Numero;
            objDb.Endereco.Rua = obj.Endereco.Rua;
            objDb.Nome = obj.Nome;
            objDb.Numero = obj.Numero;

            return _repositorio.Editar(objDb);
        }

        public List<Cliente> GetAll()
        {
            return _repositorio.GetAll();
        }

        public Cliente GetPorID(long id)
        {
            return _repositorio.GetPorID(id) ?? throw new NotFoundException();
        }

        public List<Cliente> GetPorTelefone(string telefone)
        {
            return _repositorio.GetPorTelefone(telefone);
        }


        public bool Remover(long id)
        {
            var getDb = _repositorio.GetPorID(id) ?? throw new NotFoundException();

            return _repositorio.Remover(getDb);
        }
    }
}
