using System.Data.Entity;

namespace DemystifyLocalDbSqlcmd.Models.Contexts
{
    public interface IContext
    {
        DbSet<Secret> Secrets { get; set; }
        void Dispose();
    }
}
