using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RWA_FinalProject.Controllers.api
{
    public class ProizvodiApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetProizvodi()
        {
            var p = Repo.GetProizvodi();
            return Ok(p);
        }
        /*
        [HttpGet]
        public IHttpActionResult GetProizvod(int id)
        {
            var p = Repo.GetProizvod(id);
            if (p == null) return NotFound();
            return Ok(p);
        }

        [HttpPost]
        public IHttpActionResult CreateKupac(Kupac kupac)
        {
            if (!ModelState.IsValid) return BadRequest();
            Repo.InsertKupac(kupac);
            return Ok(kupac);
        }

        [HttpPut]
        public IHttpActionResult UpdateProizvod(int id, Proizvod proizvod)
        {
            if (!ModelState.IsValid) return BadRequest();
            var pFormDB = Repo.GetProizvod(id);
            if (pFormDB == null) return NotFound();
            proizvod.IDProizvod = id;
            Repo.UpdateProizvod(proizvod);
            return Ok("Proizvod uspjesno azuriran");
        }

        [HttpDelete]
        public IHttpActionResult DeleteKupac(int id)
        {
            var p = Repo.GetProizvod(id);
            if (p == null) return NotFound();
            Repo.DeleteProizvod(id);
            return Ok("Proizvod uspjesno obrisan");
        }*/
    }
}
