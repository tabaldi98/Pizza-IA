using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Ordem_de_Compra;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Ordens
{
    public class OrdemRepositorio : IOrdemRepositorio
    {
        private PizzariaContext _context;

        public OrdemRepositorio(PizzariaContext context)
        {
            this._context = context;
        }

        public Ordem Add(Ordem obj)
        {
            var objDb = _context.Ordem.Add(obj);
            _context.SaveChanges();

            return objDb;
        }

        public List<Ordem> AddLista(List<Ordem> objs)
        {
            var objDb = _context.Ordem.AddRange(objs);
            _context.SaveChanges();

            return objDb.ToList();
        }

        public bool Editar(Ordem obj)
        {
            _context.Entry<Ordem>(obj).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public List<Ordem> GetAll()
        {
            return _context.Ordem.Include("Cliente").Include("Pizzas").Include("Bebidas").ToList();
        }

        public Ordem GetPorID(long id)
        {
            return _context.Ordem.Where(x => x.ID == id).FirstOrDefault();
        }

        public bool Remover(Ordem obj)
        {
            var getEntity = _context.Set<Ordem>().Where(e => e.ID == obj.ID).FirstOrDefault();
            if (getEntity == null)
                throw new NotFoundException();
            _context.Set<Ordem>().Remove(getEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
