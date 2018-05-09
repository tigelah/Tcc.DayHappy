using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio.FormaPagamento;

namespace Tcc.DayHappy.Data.Repositorios
{
    class PagamentoRepository : Repository<Pagamento>
    {

        public PagamentoRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override Pagamento GetById(int id)
        {
            var query = _context.Set<Pagamento>().Include(e => e.CodOrcamento.Id).Where(e => e.CodOrcamento.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Pagamento> All()
        {
            var query = _context.Set<Pagamento>().Include(p => p.CodOrcamento.Id).OrderBy(c => c.CodOrcamento);

            return query.Any() ? query.ToList() : new List<Pagamento>();
        }




    }
}
