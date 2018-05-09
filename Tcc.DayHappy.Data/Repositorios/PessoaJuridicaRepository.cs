using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Data.Repositorios
{
    class PessoaJuridicaRepository : Repository<PessoaJuridica>
    {

        public PessoaJuridicaRepository(ApplicationDbContext context) : base (context)
        {

        }

        public override PessoaJuridica GetById(int id)
        {
            var query = _context.Set<PessoaJuridica>().Include(p => p.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;

        }

        public override IEnumerable<PessoaJuridica> All()
        {
            var query = _context.Set<PessoaJuridica>().Include(p => p.Id).OrderBy(c => c.NomeEmpresa);


            return query.Any() ? query.ToList() : new List<PessoaJuridica>();
        }

    }
}
