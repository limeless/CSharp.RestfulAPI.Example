using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sum.API.Domain.Repositories;
using Sum.API.Persistence.Contexts;

namespace Sum.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
