using DemystifyLocalDbSqlcmd.Models.Contexts;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DemystifyLocalDbSqlcmd.Models.Repositories
{
    public class SecretRepository : ISecretRepository
    {
        private readonly IContext _context;

        public SecretRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Secret> GetSecret()
        {
            return await _context.Secrets.FirstAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
