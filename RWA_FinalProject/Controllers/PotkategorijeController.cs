using RWA_FinalProject.Models;
using RWA_FinalProject.Models.vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_FinalProject.Controllers
{
    public class PotkategorijeController : Controller
    {
        // GET: Potkategorije
        [Authorize]
        public ActionResult Index()
        {
            var model = Repo.GetPotkategorije();
            return View(model);
        }

        [Authorize]
        // GET: Potkategorije/Create
        public ActionResult Create()
        {
            ViewBag.kategorije = Repo.GetKategorije();
            return View();
        }
        
        // POST: Potkategorije/Create
        [HttpPost]
        public ActionResult Create(Potkategorija potkategorija)
        {
            try
            {
                // TODO: Add insert logic here
                Repo.CreatePotkategorija(potkategorija);
                return RedirectToAction("Index", "Kategorije");
            }
            catch
            {
                return View(potkategorija);
            }
        }
        [Authorize]
        // GET: Potkategorije/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Repo.GetPotkategorija(id);
            ViewBag.kategorije = Repo.GetKategorije();
            return View(model);
        }
        
        // POST: Potkategorije/Edit/5
        [HttpPost]
        public ActionResult Edit(Potkategorija potkategorija)
        {
            try
            {
                // TODO: Add update logic here
                Repo.UpdatePotkategorija(potkategorija);
                return RedirectToAction("Index", "Kategorije");
            }
            catch
            {
                return View(potkategorija);
            }
        }

       
        // POST: Potkategorije/Delete/5
      
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Repo.DeletePotkategorija(id);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK, "Potkategorija uspjesno obrisana");
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "Potkategorija nije obrisana");
            }
        }
    }
}
