using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace DemystifyLocalDbSqlcmd.Models.Contexts
{
    internal class ApplicationDatabaseInitialize : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            context.Secrets.AddOrUpdate(new Secret { Id = 1, Message = "Hello LocalDB!"});
        }
    }
}
