using Microsoft.AspNetCore.Mvc;

namespace Namery.Controllers
{
    public class NameryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
