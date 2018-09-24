using Pizzaria.Domain.Features.Enderecos;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Enderecos
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private PizzariaContext _context;
        public EnderecoRepositorio(PizzariaContext context)
        {
            _context = context;
        }
        public Endereco Add(Endereco obj)
        {
            var endereco = _context.Endereco.Add(obj);
            _context.SaveChanges();

            return endereco;
        }

        public List<Endereco> AddLista(List<Endereco> objs)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Endereco obj)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> GetAll()
        {
            return _context.Endereco.ToList();
        }

        public Endereco GetPorID(long id)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> ObterPorCidade(string cidade)
        {
            return _context.Endereco.Where(x => x.Cidade.Contains(cidade)).ToList();
        }

        public bool Remover(Endereco obj)
        {
            throw new NotImplementedException();
        }
    }
}
