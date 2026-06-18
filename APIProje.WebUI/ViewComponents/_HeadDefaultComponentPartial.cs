using Microsoft.AspNetCore.Mvc;

namespace APIProje.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
