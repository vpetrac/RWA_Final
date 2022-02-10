using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models
{
    public class Proizvod
    {
        public int IDProizvod { get; set; }
        [Required(ErrorMessage = "Naziv je obvezan")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Obezan podatak")]
        public string BrojProizvoda { get; set; }
        [Required(ErrorMessage = "Obezan podatak")]
        public string Boja { get; set; }
        [Required(ErrorMessage = "Obezan podatak")]
        public short MinimalnaKolicinaNaSkladistu { get; set; }
        public decimal CijenaBezPDV { get; set; }
        [Required(ErrorMessage = "Obezan podatak")]
        public Potkategorija Podkategorija { get; set; }

    }
}