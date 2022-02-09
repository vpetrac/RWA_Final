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
        public ActionResult Index()
        {
            var model = Repo.GetPotkategorije();
            return View(model);
        }

        
        // GET: Potkategorije/Create
        public ActionResult Create()
        {
            ViewBag.kategorije = Repo.GetKategorije();
            return View();
        }

        // POST: Potkategorije/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Potkategorije/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Potkategorije/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Potkategorije/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Potkategorije/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
