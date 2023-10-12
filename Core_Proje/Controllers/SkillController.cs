﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Yetenek Listesi";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Listesi";
            var values=skillManager.GetList();  
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.d1 = "Yetenek Ekleme";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id){ 
            var values=skillManager.TGetBtID(id);
            skillManager.TDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.d1 = "Yetenek Güncelleme";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Güncelleme";
            var values=skillManager.TGetBtID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");

        }
    }
}
