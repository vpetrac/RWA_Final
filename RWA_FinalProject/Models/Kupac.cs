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
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obvezno")]
        public string Prezime { get; set; }
        [EmailAddress(ErrorMessage = "Email je obvezan")]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Display(Name = "Grad")]
        [Required(ErrorMessage = "Niste odabrali grad")]
        public int GradID { get; set; }
        
        public string PunoIme
        {
            get { return $"{Ime} {Prezime}"; }
        }
        public override string ToString() => $"{Ime} {Prezime}";
        
    }
}