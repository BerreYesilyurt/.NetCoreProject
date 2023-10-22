using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    public class DefaultController : Controller
    {
        [Area("Writer")] /*Hangi area ile çalışıldığının belirtlmesi için bir attribute*/
        public IActionResult Index()
        {
            return View();
        }
    }
}
