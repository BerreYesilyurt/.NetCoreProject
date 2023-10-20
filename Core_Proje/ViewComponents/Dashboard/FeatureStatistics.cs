using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.d1 = c.Skills.Count();
            ViewBag.d2=c.Messages.Where(x=>x.Status==false).Count();  
            ViewBag.d3= c.Messages.Where(x => x.Status == true).Count();
            ViewBag.d4= c.Experiences.Count();
            return View();  
        }
    }
}
