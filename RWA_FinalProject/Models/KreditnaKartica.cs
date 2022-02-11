using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models
{
    public class KreditnaKartica
    {
        public int IdKreditnaKartica { get; set; }
        public string Tip { get; set; }

        public override string ToString()
        {
            return Tip;
        }
    }
}