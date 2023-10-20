using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager portfolio = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values=portfolio.GetList(); 
            return View(values);
        }
    }
}
