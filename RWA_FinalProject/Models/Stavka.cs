using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models
{
    public class Stavka
    {
        public int IDStavka { get; set; }
        public int RacunID { get; set; }
        public short Kolicina { get; set; }
        public int ProizvodId { get; set; }
        public decimal CijenaPoKomadu { get; set; }
        public decimal PopustUPostotcima { get; set; }
        public decimal UkupnaCijena { get; set; }
    }
}