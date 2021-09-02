using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RWA_FinalProject.Models
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        [Required(ErrorMessage = "Ime je obvezno")]
        public int Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obvezno")]
        public int Prezime { get; set; }
        [EmailAddress(ErrorMessage = "Ime je obvezno")]
        public int Email { get; set; }
        public int Telefon { get; set; }
        [Display(Name = "Grad")]
        [Required(ErrorMessage = "Niste odabrali grad")]
        public Grad Grad { get; set; }
        
        public string PunoIme
        {
            get { return $"{Ime} {Prezime}"; }
        }
        public override string ToString() => $"{Ime} {Prezime}";
        
    }
}