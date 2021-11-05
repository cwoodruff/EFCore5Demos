using Chinook;
using Microsoft.EntityFrameworkCore;

namespace dbcontentfactory
{
    class Program
    {
        private static IDbContextFactory<ChinookContext> _contextFactory;
        public Program(IDbContextFactory<ChinookContext> contextFactory) => _contextFactory = contextFactory;
        
        static void Main()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                // ...
            }
        }
    }
}