using Microsoft.AspNetCore.Mvc;

namespace APIProje.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
