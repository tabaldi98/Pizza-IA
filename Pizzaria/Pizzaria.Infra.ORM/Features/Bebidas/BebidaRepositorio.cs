using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Bebidas
{
    public class BebidaRepositorio : IBebidaRepositorio
    {
        private PizzariaContext _context;

        public BebidaRepositorio(PizzariaContext context)
        {
            this._context = context;
        }

        public Bebida Add(Bebida obj)
        {
            var objDb = _context.Bebida.Add(obj);
            _context.SaveChanges();

            return objDb;
        }

        public List<Bebida> AddLista(List<Bebida> objs)
        {
            var objDb = _context.Bebida.AddRange(objs);
            _context.SaveChanges();

            return objDb.ToList();
        }

        public bool Editar(Bebida obj)
        {
            _context.Entry<Bebida>(obj).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public List<Bebida> GetAll()
        {
            return _context.Bebida.Include("Sabor").ToList();
        }

        public Bebida GetPorID(long id)
        {
            return _context.Bebida.Where(x => x.ID == id).Include("Sabor").FirstOrDefault();
        }

        public bool Remover(Bebida obj)
        {
            var getEntity = _context.Set<Bebida>().Where(e => e.ID == obj.ID).FirstOrDefault();
            if (getEntity == null)
                throw new NotFoundException();
            _context.Set<Bebida>().Remove(getEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
