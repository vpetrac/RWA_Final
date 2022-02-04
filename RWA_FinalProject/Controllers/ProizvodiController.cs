﻿using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_FinalProject.Controllers
{
    public class ProizvodiController : Controller
    {
        // GET: Proizvodi
        public ActionResult Index()
        {

            var model = Repo.GetProizvodi();
            return View(model);
        }

        // GET: Proizvodi/Details/5
        public ActionResult Details(int id)
        {
            //sql impl
            var model = Repo.GetProizvod();
            return View();
        }

        // GET: Proizvodi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proizvodi/Create
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

        // GET: Proizvodi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proizvodi/Edit/5
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

        // GET: Proizvodi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proizvodi/Delete/5
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