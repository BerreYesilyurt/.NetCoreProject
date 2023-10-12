﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Deneyim Listesi";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Listesi";
            var values = experienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.d1 = "Deneyim Ekleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Ekleme";
            return View();

        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteExperience(int id) {
            var values=experienceManager.TGetBtID(id);  
            experienceManager.TDelete(values);  
            return RedirectToAction("Index");  
            
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.d1 = "Deneyim Güncelleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Güncelleme";
            var values = experienceManager.TGetBtID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {         
            
            experienceManager.TUpdate(experience);   
            return RedirectToAction("Index");

        }
    }
}
