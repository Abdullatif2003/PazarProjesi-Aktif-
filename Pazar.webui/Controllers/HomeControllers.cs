using Microsoft.AspNetCore.Mvc;

namespace Pazar.webui.Controllers
{
    public class HomeControllers:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}