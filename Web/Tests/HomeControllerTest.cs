using DemystifyLocalDbSqlcmd.Controllers;
using DemystifyLocalDbSqlcmd.Models;
using DemystifyLocalDbSqlcmd.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DemystifyLocalDbSqlcmd.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod, TestCategory("Unit")]
        public async Task Controller_HomeIndex()
        {
            var mock = new Mock<ISecretRepository>();
            mock.Setup(m => m.GetSecret()).ReturnsAsync(new Secret { Message = "secret content" });
            var controller = new HomeController(mock.Object);
            var result = await controller.Index() as ContentResult;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Content);
        }
    }
}
