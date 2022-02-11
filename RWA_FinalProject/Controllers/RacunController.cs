using RWA_FinalProject.Models;
using RWA_FinalProject.Models.vm;
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
        [Authorize]
        // GET: Racun/Detalji/5
        public ActionResult Detalji(int id)
        {
            VMRacunStavke racunStavke = new VMRacunStavke(id);
            ViewBag.proizvodi = Repo.GetProizvodi();
            return View(racunStavke);
            
        }
        [Authorize]
        public ActionResult PremaKupcu(int id)
        {
            ViewBag.ID = id;
            return View();
        }


        
    }
}
