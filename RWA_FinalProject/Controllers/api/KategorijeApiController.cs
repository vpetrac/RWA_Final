using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace RWA_FinalProject.Controllers
{
    public class KategorijeApiController : ApiController
    {
        public IHttpActionResult GetKategorije()
        {
            var kategorije = Repo.GetKategorije();
            return Ok(kategorije);
        }

        [HttpGet]
        public IHttpActionResult GetKategorija(int id)
        {
            var p = Repo.GetKategorija(id);
            if (p == null) return NotFound();
            return Ok(p);
        }

        [HttpPost]
        public IHttpActionResult CreateKategorija(Kategorija kategorija)
        {
            if (!ModelState.IsValid) return BadRequest();
            Repo.CreateKategorija(kategorija);
            return Ok(kategorija);
        }

        [HttpPut]
        public IHttpActionResult UpdateKategorija(int id, Kategorija kategorija)
        {
            if (!ModelState.IsValid) return BadRequest();
            var pFormDB = Repo.GetKategorija(id);
            if (pFormDB == null) return NotFound();
            kategorija.IDKategorija = id;
            Repo.UpdateKategorija(kategorija);
            return Ok("Kategorija uspjesno azurirana");
        }

        [HttpDelete]
        public IHttpActionResult DeleteKategorija(int id)
        {
            var p = Repo.GetKategorija(id);
            if (p == null) return NotFound();
            Repo.DeleteKategorija(id);
            return Ok("Kategorija uspjesno obrisana");
        }
    }
}
