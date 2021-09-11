using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RWA_FinalProject.Controllers
{
    public class PotkategorijeController : ApiController
    {


        [HttpGet]
        public IHttpActionResult GetPotkategorije()
        {
            var potkategorije = Repo.GetPotkategorije();
            //var kupciDto = AutoMapperConfig.Mapper.Map<IEnumerable<KupacDto>>(kupci);
            return Ok(potkategorije);
        }
        [HttpGet]
        public IHttpActionResult GetPotkategorija(int id)
        {
            var p = Repo.GetPotkategorija(id);
            if (p == null) return NotFound();
            return Ok(p);
        }

        [HttpPost]
        public IHttpActionResult CreateKategorija(Podkategorija potkategorija)
        {
            if (!ModelState.IsValid) return BadRequest();
            Repo.CreatePotkategorija(potkategorija);
            return Ok(potkategorija);
        }

        [HttpPut]
        public IHttpActionResult UpdatePotkategorija(int id, Podkategorija potkategorija)
        {
            if (!ModelState.IsValid) return BadRequest();
            var pFormDB = Repo.GetPotkategorija(id);
            if (pFormDB == null) return NotFound();
            potkategorija.IDPotkategorija = id;
            Repo.UpdatePotkategorija(potkategorija);
            return Ok("Potkategorija uspjesno azurirana");
        }

        [HttpDelete]
        public IHttpActionResult DeletePotkategorija(int id)
        {
            var p = Repo.GetPotkategorija(id);
            if (p == null) return NotFound();
            Repo.DeletePotkategorija(id);
            return Ok("Potkategorija uspjesno obrisana");
        }
    }
}
