using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace RWA_FinalProject.Models
{
    public class Racun
    {
        public int IDRacun { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string BrojRacuna { get; set; }
        public string Komentar { get; set; }
        public KreditnaKartica KreditnaKartica { get; set; }
        public Komercijalist Komercijalist { get; set; }

    }
}