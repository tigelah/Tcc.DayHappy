﻿using System.Threading.Tasks;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Dominio;

namespace Tcc.DayHappy.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
