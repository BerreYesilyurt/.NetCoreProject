using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal()); // Burada GenericRepository kullanabilmek için EF'ü parametre olarak yolluyoruz.
        public IViewComponentResult Invoke()
        {
            var vaLues = featureManager.GetList();
            return View(vaLues);
        }
    }
}
