using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RWA_FinalProject.Models
{
    public class Potkategorija
    {
        public int IDPotkategorija { get; set; }
        [Required(ErrorMessage = "Naziv kategorije je obvezan")]
        public string Naziv { get; set; }
        
        public int KategorijaID { get; set; }
    }
}