using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class HeroController : Controller
    {
        ApplicationDbContext db;
        public HeroController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Hero
        public ActionResult Heroes()
        {
            return View(db.SuperHeroes);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            return View(db.SuperHeroes.Find(id));
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(SuperHero hero)
        {
            try
            {
                db.SuperHeroes.Add(hero);
                db.SaveChanges();
                return RedirectToAction("Heroes");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.SuperHeroes.Find(id));
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(SuperHero hero)
        {
            try
            {
                db.SuperHeroes.Find(hero.Id).Name = hero.Name;
                db.SuperHeroes.Find(hero.Id).AlterEgo = hero.AlterEgo;
                db.SuperHeroes.Find(hero.Id).PrimaryAbility = hero.PrimaryAbility;
                db.SuperHeroes.Find(hero.Id).SecondaryAbility = hero.SecondaryAbility;
                db.SuperHeroes.Find(hero.Id).Catchphrase = hero.Catchphrase;
                db.SaveChanges();
                return RedirectToAction("Heroes");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.SuperHeroes.Find(id));
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(SuperHero hero)
        {
            try
            {
                db.SuperHeroes.Remove(db.SuperHeroes.Find(hero.Id));
                db.SaveChanges();
                return RedirectToAction("Heroes");
            }
            catch
            {
                return View();
            }
        }
    }
}
