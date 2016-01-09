using System;
using System.Threading.Tasks;

namespace DemystifyLocalDbSqlcmd.Models.Repositories
{
    public interface ISecretRepository : IDisposable
    {
        Task<Secret> GetSecret();
    }
}
