using RWA_FinalProject.Models;
using RWA_FinalProject.Models.vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_FinalProject.Controllers
{
    public class KategorijeController : Controller
    {
        // GET: Kategorije
        
        [Authorize]
        public ActionResult Index()
        {
            var model = Repo.GetKategorije();
            return View(model);
        }
        [Authorize]
        // GET: Kategorije/Details/5
        public ActionResult Details(int id)
        {
            VMKategorijePotkategorije vMKategorijePotkategorije = new VMKategorijePotkategorije(id);
            return View(vMKategorijePotkategorije);
        }
        [Authorize]
        // GET: Kategorije/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategorije/Create
        [HttpPost]
        public ActionResult Create(Kategorija kategorija)
        {
            try
            {
                // TODO: Add insert logic here
                Repo.CreateKategorija(kategorija);
                return RedirectToAction("Index", "Kategorije");
            }
            catch
            {
                return View();
            }
        }
        [Authorize]
        // GET: Kategorije/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Repo.GetKategorija(id);
            return View(model);
        }

        // POST: Kategorije/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Kategorija kategorija)
        {
            
            if (ModelState.IsValid)
            {
                Repo.UpdateKategorija(kategorija);
                return RedirectToAction("Index", "Kategorije");
            }
            else
            {
                return View(kategorija);
            }
        }
        [Authorize]
        // GET: Kategorije/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Repo.GetKategorija(id);
            return View(model);
        }
        [Authorize]
        // POST: Kategorije/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Repo.DeleteKategorija(id);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK, "Kategorija uspjesno obrisana");
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "Kategorija nije obrisana");
            }
        }
    }
}
