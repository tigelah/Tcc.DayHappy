using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;

namespace Tcc.DayHappy.Data.Repositorios
{
    /*
    public class EventoRepository : Repository<Evento>
    {

        public EventoRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override Evento GetById(int id)
        {
            var query = _context.Set<Evento>().Include(e => e.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Evento> All()
        {
            var query = _context.Set<Evento>().Include(p => p.Id).OrderBy(c => c.CodOrcamento);

            return query.Any() ? query.ToList() : new List<Evento>();
        }




    }
    */
}
