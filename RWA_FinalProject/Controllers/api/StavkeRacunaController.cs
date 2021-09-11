using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RWA_FinalProject.Controllers.api
{
    public class StavkeRacunaController : ApiController
    {
        public IHttpActionResult GetRacuniKupca(int id)
        {
            var stavke = Repo.GetStavke(id);
            //var kupciDto = AutoMapperConfig.Mapper.Map<IEnumerable<KupacDto>>(kupci);
            return Ok(stavke);
        }
    }
}
