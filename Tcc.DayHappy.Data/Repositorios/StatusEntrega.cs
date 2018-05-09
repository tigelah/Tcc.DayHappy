using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio.Produtos;
using Tcc.DayHappy.Dominio.StatusEntregas;

namespace Tcc.DayHappy.Data.Repositorios
{
    class StatusEntregaRepository : Repository<StatusEntrega>
    {
        public StatusEntregaRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override StatusEntrega GetById(int id)
        {
            var query = _context.Set<StatusEntrega>().Include(e => e.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<StatusEntrega> All()
        {
            var query = _context.Set<StatusEntrega>().Include(p => p.Id).OrderBy(c => c.CodEvento.CodOrcamento.DataEvento);

            return query.Any() ? query.ToList() : new List<StatusEntrega>();
        }

    }
}
