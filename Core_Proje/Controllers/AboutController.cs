﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.d1 = "Hakkımdakiler";
            ViewBag.d2 = "Hakkımda";
            ViewBag.d3 = "Hakkımdakiler";
            var values = aboutManager.TGetBtID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}