using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models
{
    public class Proizvod
    {
        public int IDProizvod { get; set; }
        public string Naziv { get; set; }
        public int BrojProizvoda { get; set; }
        public string Boja { get; set; }
        public int MinimalnaKolicinaNaKladistu { get; set; }
        public double CijenaBezPDV { get; set; }
        public Podkategorija Podkategorija { get; set; }

    }
}