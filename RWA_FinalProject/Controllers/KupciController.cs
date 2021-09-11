using RWA_FinalProject.App_Start;
using RWA_FinalProject.Models;
using RWA_FinalProject.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RWA_FinalProject.Controllers
{
    public class KupciController : ApiController
    {
        // GET      /api/kupci      -svi kupci
        // GET      /api/kupci/1    -konkretan kupac
        // POST     /api/kupci      -dodavanje kupca
        // PUT      /api/kupci/1    -azuriranej kupca
        // DELETE   /api/kupci/1    -brisanje kupca

        [HttpGet]
        public IHttpActionResult GetKupci()
        {
            var kupci = Repo.GetKupci();
            var kupciDto = AutoMapperConfig.Mapper.Map<IEnumerable<KupacDto>>(kupci);
            return Ok(kupciDto);
        }

        [HttpGet]
        public IHttpActionResult GetKupac(int id)
        {
            var kupac = Repo.GetKupac(id);
            if (kupac == null) return NotFound();
            var kupacDto = AutoMapperConfig.Mapper.Map<KupacDto>(kupac);
            return Ok(kupacDto);
      
        }

        [HttpPut]
        public IHttpActionResult UpdateKupac(int id, Kupac kupac)
        {
            if (!ModelState.IsValid) return BadRequest();
            var kupacFromDB = Repo.GetKupac(id);
            if (kupacFromDB == null) return NotFound();
            kupac.IDKupac = id;
            Repo.UpdateKupac(kupac);
            return Ok("Kupac uspješno azuriran");
            
        }

    }
}
