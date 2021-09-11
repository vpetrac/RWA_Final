using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models.dto
{
    public class KupacDto
    {
        public int IDKupac { get; set; }
        [Required(ErrorMessage = "Ime je obvezno")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obvezno")]
        public string Prezime { get; set; }
        [EmailAddress(ErrorMessage = "Email je obvezan")]
        public string Email { get; set; }
        public string Telefon { get; set; }
        
    }
}