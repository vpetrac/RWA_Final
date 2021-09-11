using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_FinalProject.Controllers
{
    public class RacunController : Controller
    {
        // GET: Racun
        public ActionResult Index()
        {
            return View();
        }

        // GET: Racun/Detalji/5
        public ActionResult Detalji(int id)
        {
            ViewData["Racun"] = Repo.GetRacun(id);
            ViewData["Stavke"] = Repo.GetStavke(id);
            return View();
        }

        public ActionResult PremaKupcu(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        
    }
}
