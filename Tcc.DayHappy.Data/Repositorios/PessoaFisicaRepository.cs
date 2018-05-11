using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Data.Repositorios
{
   public class PessoaFisicaRepository : Repository<PessoaFisica>
    {

        public PessoaFisicaRepository(ApplicationDbContext context) : base (context)
        {

        }

        public override PessoaFisica GetById(int id)
        {
            var query = _context.Set<PessoaFisica>().Include(p => p.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;

        }

        public override IEnumerable<PessoaFisica> All()
        {
            var query = _context.Set<PessoaFisica>().Include(p => p.Id).OrderBy(c => c.Pessoa.Nome);


            return query.Any() ? query.ToList() : new List<PessoaFisica>();
        }


    }
}
