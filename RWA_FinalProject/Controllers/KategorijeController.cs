using RWA_FinalProject.Models;
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
        public ActionResult Index()
        {
            var model = Repo.GetKategorije();
            return View(model);
        }

        // GET: Kategorije/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kategorije/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategorije/Create
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

        // GET: Kategorije/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kategorije/Edit/5
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

        // GET: Kategorije/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kategorije/Delete/5
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
