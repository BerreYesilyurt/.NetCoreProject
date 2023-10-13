﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.d1 = "Öne Çıkanlar";
            ViewBag.d2 = "Öne Çıkan";
            ViewBag.d3 = "Öne Çıkanlar";
            var values = featureManager.TGetBtID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");

        }
    }
}
