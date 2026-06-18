using Microsoft.AspNetCore.Mvc;

namespace APIProje.WebUI1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
