using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio.Produtos;

namespace Tcc.DayHappy.Data.Repositorios
{
   public  class ProdutoRepository :  Repository<Produto>
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {

        }
        public override Produto GetById(int id)
        {
            var query = _context.Set<Produto>().Include(e => e.Id).Where(e => e.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }

        public override IEnumerable<Produto> All()
        {
            var query = _context.Set<Produto>().OrderBy(c => c.NomeProduto);

            return query.Any() ? query.ToList() : new List<Produto>();
        }
    }
}
