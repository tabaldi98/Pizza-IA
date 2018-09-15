using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Pizzas
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
        private PizzariaContext _context;

        public PizzaRepositorio(PizzariaContext context)
        {
            this._context = context;
        }

        public Pizza Add(Pizza obj)
        {
            var objDb = _context.Pizza.Add(obj);
            _context.SaveChanges();

            return objDb;
        }

        public List<Pizza> AddLista(List<Pizza> objs)
        {
            var objDb = _context.Pizza.AddRange(objs);
            _context.SaveChanges();

            return objDb.ToList();
        }

        public bool Editar(Pizza obj)
        {
            _context.Entry<Pizza>(obj).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public List<Pizza> GetAll()
        {
            return _context.Pizza.Include("Sabores").ToList();
        }

        public Pizza GetPorID(long id)
        {
            return _context.Pizza.Where(x => x.ID == id).Include("Sabores").FirstOrDefault();
        }

        public bool Remover(Pizza obj)
        {
            var getEntity = _context.Set<Pizza>().Where(e => e.ID == obj.ID).FirstOrDefault();
            if (getEntity == null)
                throw new NotFoundException();
            _context.Set<Pizza>().Remove(getEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
