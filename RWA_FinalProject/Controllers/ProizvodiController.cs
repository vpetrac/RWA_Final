using RWA_FinalProject.Models;
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
        [Authorize]
        public ActionResult Index()
        {
            var model = Repo.GetProizvodi();
            return View(model);
        }

        // GET: Proizvodi/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            var model = Repo.GetProizvod(id);
            ViewBag.potkategorije = Repo.GetPotkategorije();
            return View(model);
        }

        // GET: Proizvodi/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.potkategorije = Repo.GetPotkategorije();
            return View();
        }

        // POST: Proizvodi/Create
        [HttpPost]
        public ActionResult Create(Proizvod proizvod)
        {
            try
            {
                // TODO: Add insert logic here
                Repo.CreateProizvod(proizvod);
                return RedirectToAction("Index", "Proizvodi");
            }
            catch
            {
                return View(proizvod);
            }
        }

        // GET: Proizvodi/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var model = Repo.GetProizvod(id);
            ViewBag.potkategorije = Repo.GetPotkategorije();
            return View(model);
        }

        // POST: Proizvodi/Edit/5
        [HttpPost]
        public ActionResult Edit(Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                Repo.UpdateProizvod(proizvod);
                return RedirectToAction("Index","Proizvodi") ;
            }
            else
            {
                return View(proizvod);
            }
        }


        public ActionResult Delete(int id)
        {
            try
            {
                Repo.DeleteProizvod(id);
                //return Json(new { message = "Proizvod uspješno obrisan" }, JsonRequestBehavior.AllowGet);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest, "Proizvod nije obrisan.");
            }
        }
    }
}
