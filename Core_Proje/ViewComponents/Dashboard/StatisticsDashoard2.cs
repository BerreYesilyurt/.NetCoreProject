using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashoard2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.d1 = c.Portfolios.Count();
            ViewBag.d2=c.Messages.Count();
            ViewBag.d3=c.Services.Count();
            return View();
        }
    }
}
