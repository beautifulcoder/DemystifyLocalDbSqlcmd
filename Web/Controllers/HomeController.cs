using DemystifyLocalDbSqlcmd.Models.Contexts;
using DemystifyLocalDbSqlcmd.Models.Repositories;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DemystifyLocalDbSqlcmd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISecretRepository _secretRepository;

        public HomeController(ISecretRepository secretRepository)
        {
            _secretRepository = secretRepository;
        }

        public HomeController() : this(new SecretRepository(new ApplicationDbContext()))
        {
        }

        public async Task<ActionResult> Index()
        {
            var secret = await _secretRepository.GetSecret();
            return Content(secret.Message);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _secretRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
