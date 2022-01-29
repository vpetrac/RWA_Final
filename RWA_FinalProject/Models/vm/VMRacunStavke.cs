using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models.vm
{
    public class VMRacunStavke
    {
        public Racun Racun { get; set; }
        public IEnumerable<Stavka> Stavke { get; set; }

        public VMRacunStavke(int racunId)
        {
           Racun = Repo.GetRacun(racunId);
           Stavke = Repo.GetStavke(racunId);

        }
    }
}