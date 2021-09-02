using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RWA_FinalProject.Models
{
    public class Komercijalist
    {
        public int IDKomercijalist { get; set; }
        [Required(ErrorMessage = "Ime je obvezno")]
        public int Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obvezno")]
        public int Prezime { get; set; }
        public bool StalniZaposlenik { get; set; }
    }
}