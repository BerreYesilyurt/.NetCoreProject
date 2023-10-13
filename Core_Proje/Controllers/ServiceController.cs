using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Hizmet Listesi";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Listesi";
            var values = serviceManager.GetList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetBtID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id) {
            ViewBag.d1 = "Hizmet Güncelleme";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Güncelleme";
            var values=serviceManager.TGetBtID(id);
            return View(values);    
           

        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            ViewBag.d1 = "Hizmet Güncelleme";
            ViewBag.d2 = "Hizmetler";
            ViewBag.d3 = "Hizmet Güncelleme";
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");


        }
    }
}
