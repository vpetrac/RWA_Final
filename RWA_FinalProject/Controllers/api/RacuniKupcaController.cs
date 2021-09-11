using RWA_FinalProject.App_Start;
using RWA_FinalProject.Models;
using RWA_FinalProject.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;


namespace RWA_FinalProject.Controllers
{
    public class RacuniKupcaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetRacuniKupca(int id)
        {
            var racuniKupca = Repo.GetRacuniForKupac(id);
            //var kupciDto = AutoMapperConfig.Mapper.Map<IEnumerable<KupacDto>>(kupci);
            return Ok(racuniKupca);
        }
    }
}