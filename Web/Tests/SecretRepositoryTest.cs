using DemystifyLocalDbSqlcmd.Models.Contexts;
using DemystifyLocalDbSqlcmd.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DemystifyLocalDbSqlcmd.Tests
{
    [TestClass]
    public class SecretRepositoryTest
    {
        [TestMethod, TestCategory("Integration")]
        public async Task Repository_SecretGetSecretId()
        {
            Database.SetInitializer(new ApplicationDatabaseInitialize());
            var context = new ApplicationDbContext();
            var repo = new SecretRepository(context);
            var result = await repo.GetSecret();
            Assert.AreEqual(1, result.Id);
        }

        [TestMethod, TestCategory("Integration")]
        public async Task Repository_SecretGetSecretMessage()
        {
            Database.SetInitializer(new ApplicationDatabaseInitialize());
            var context = new ApplicationDbContext();
            var repo = new SecretRepository(context);
            var result = await repo.GetSecret();
            Assert.IsNotNull(result.Message);
        }
    }
}
