using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWA_FinalProject.Controllers
{
    public class ListaStavkiController : Controller
    {
        // GET: ListaStavki
        public ActionResult ListaStavki(int racunID)
        {
            var lista = Repo.GetStavke(racunID);
            return View(lista);
        }
    }
}