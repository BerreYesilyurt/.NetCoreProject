using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Proje Listesi";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Listesi";
            var values=portfolioManager.GetList();  
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.d1 = "Proje Ekleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            ViewBag.d1 = "Proje Ekleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Ekleme";
            PortfolioValidator portfolioValidator=new PortfolioValidator(); 
            ValidationResult results=portfolioValidator.Validate(portfolio);
            if(results.IsValid) {
                portfolioManager.TAdd(portfolio);

            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values=portfolioManager.TGetBtID(id);   
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.d1 = "Proje Güncelleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Güncelleme";
            var values = portfolioManager.TGetBtID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            ViewBag.d1 = "Proje Güncelleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Güncelleme";
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results=validations.Validate(portfolio); // portfolio parametresinden gelen değeri, validations nesnesi aracılığıyla validate ediyor.
            if(results.IsValid )
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");

            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage); 
                }
            }

            return View();
            
            

        }
    }
}
