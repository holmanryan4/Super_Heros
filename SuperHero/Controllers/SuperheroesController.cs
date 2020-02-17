using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class SuperheroesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SuperheroesController(ApplicationDbContext context)
        {
            _context = context;
        }
           
        // GET: Superheros
        public ActionResult Index()
        {
            List<Models.Superhero> Supers = _context.Superheroes.ToList();
           
            return View(Supers);
        }

        // GET: Superheros/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = _context.Superheroes.Where(s => s.Id == id).FirstOrDefault();

            return View(superhero);
        }

        // GET: Superheros/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            if(ModelState.IsValid)
            {
                // TODO: Add insert logic here

                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            
                return View();
            
        }

        // GET: Superheros/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = _context.Superheroes.Find(id);
            return View(superhero);
        }

        // POST: Superheros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero superhero)
        {
            if(ModelState.IsValid)
            {
                // TODO: Add update logic here

                Superhero Dbheroes = _context.Superheroes.Where(s => s.Id == superhero.Id).FirstOrDefault();
                Dbheroes.Name = superhero.Name;
                Dbheroes.AlterEgo = superhero.AlterEgo;
                Dbheroes.primarySuperheroAbility = superhero.primarySuperheroAbility;
                Dbheroes.SecondarySuperheroAbility = superhero.SecondarySuperheroAbility;
                Dbheroes.Catchphrase = superhero.Catchphrase;
                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            
            
                return View();
            
        }

        // GET: Superheros/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = _context.Superheroes.Find(id);
            return View(superhero);
        }

        // POST: Superheros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Delete");
            }
                
            
        }
    }
}