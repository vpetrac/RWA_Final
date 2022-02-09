using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models.vm
{
    public class VMKategorijePotkategorije
    {
        public Kategorija kategorija { get; set; }
        public IEnumerable<Potkategorija> Podkategorije { get; set; }

        public VMKategorijePotkategorije(int kategorijaId)
        {
            kategorija = Repo.GetKategorija(kategorijaId);
            Podkategorije = Repo.GetPotkategorije().Where(item => item.KategorijaID == kategorijaId);


        }
    }
}