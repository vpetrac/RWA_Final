﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RWA_FinalProject.Models
{
    public class Podkategorija
    {
        public int IDPodkategorija { get; set; }
        [Required(ErrorMessage = "Naziv kategorije je obvezan")]
        public int Naziv { get; set; }
    }
}