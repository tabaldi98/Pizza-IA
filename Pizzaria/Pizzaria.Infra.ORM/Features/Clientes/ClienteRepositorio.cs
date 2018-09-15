using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Clientes
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private PizzariaContext _context;

        public ClienteRepositorio(PizzariaContext context)
        {
            this._context = context;
        }

        public Cliente Add(Cliente obj)
        {
            var objDb = _context.Cliente.Add(obj);
            _context.SaveChanges();

            return objDb;
        }

        public List<Cliente> AddLista(List<Cliente> objs)
        {
            var objDb = _context.Cliente.AddRange(objs);
            _context.SaveChanges();

            return objDb.ToList();
        }

        public bool Editar(Cliente obj)
        {
            _context.Entry<Cliente>(obj).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public List<Cliente> GetAll()
        {
            return _context.Cliente.Include("Endereco").ToList();
        }

        public Cliente GetPorID(long id)
        {
            return _context.Cliente.Where(x => x.ID == id).Include("Endereco").FirstOrDefault();
        }

        public bool Remover(Cliente obj)
        {
            var getEntity = _context.Set<Cliente>().Where(e => e.ID == obj.ID).FirstOrDefault();
            if (getEntity == null)
                throw new NotFoundException();
            _context.Set<Cliente>().Remove(getEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
