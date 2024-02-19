using Microsoft.AspNetCore.Mvc;

namespace PortalHinosApp.Web.Controllers
{
    public class RelatorioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
