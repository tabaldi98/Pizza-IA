using Pizzaria.Domain.Exceptions;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using Pizzaria.Infra.ORM.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.ORM.Features.Sabores
{
    public class SaborRepositorio : ISaborRepositorio
    {
        private PizzariaContext _context;

        public SaborRepositorio(PizzariaContext context)
        {
            this._context = context;
        }

        public Sabor Add(Sabor obj)
        {
            var objDb = _context.Sabor.Add(obj);
            _context.SaveChanges();

            return objDb;
        }

        public List<Sabor> AddLista(List<Sabor> objs)
        {
            var objDb = _context.Sabor.AddRange(objs);
            _context.SaveChanges();

            return objDb.ToList();
        }

        public bool Editar(Sabor obj)
        {
            _context.Entry<Sabor>(obj).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public List<Sabor> GetAll()
        {
            return _context.Sabor.ToList();
        }

        public List<Sabor> GetAllPorTipo(TipoSabor tipoSabor)
        {
            return _context.Sabor.Where(x => x.TipoSabor == tipoSabor).ToList();

        }

        public Sabor GetPorID(long id)
        {
            return _context.Sabor.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Sabor> ObterPorDescricao(string sabor, TipoSabor tipoSabor)
        {
            return _context.Sabor.Where(x => x.TipoSabor == tipoSabor && x.Descricao.Contains(sabor)).ToList();
        }

        public bool Remover(Sabor obj)
        {
            var getEntity = _context.Set<Sabor>().Where(e => e.ID == obj.ID).FirstOrDefault();
            if (getEntity == null)
                throw new NotFoundException();
            _context.Set<Sabor>().Remove(getEntity);
            return _context.SaveChanges() > 0;
        }
    }
}
