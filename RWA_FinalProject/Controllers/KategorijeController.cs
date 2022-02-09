﻿using RWA_FinalProject.Models;
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
        public ActionResult Index()
        {
            var model = Repo.GetKategorije();
            return View(model);
        }

        // GET: Kategorije/Details/5
        public ActionResult Details(int id)
        {
            VMKategorijePotkategorije vMKategorijePotkategorije = new VMKategorijePotkategorije(id);
            return View(vMKategorijePotkategorije);
        }

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
                return RedirectToAction("Index");
            }
            else
            {
                return View(kategorija);
            }
        }

        // GET: Kategorije/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Repo.GetKategorija(id);
            return View(model);
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
