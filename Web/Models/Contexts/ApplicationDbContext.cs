using System.Data.Entity;
using System.Diagnostics;

namespace DemystifyLocalDbSqlcmd.Models.Contexts
{
    internal class ApplicationDbContext : DbContext, IContext
    {
        internal ApplicationDbContext()
            : base(@"Server=(localdb)\MSSQLLocalDB;
                AttachDbFilename=C:\Dev\Publish\DemystifyLocalDbSqlcmd\Web\App_Data\DemystifyLocalDbSqlcmd.mdf;
                Trusted_Connection=True")
        {
            Database.Log = s => Trace.WriteLine(s);
        }

        public DbSet<Secret> Secrets { get; set; }
    }
}
