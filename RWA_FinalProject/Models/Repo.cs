﻿using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace RWA_FinalProject.Models
{
    public class Repo
    {
        private static DataSet ds { get; set; }
        public static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public static IEnumerable<Kupac> GetKupci()
        {
            ds = SqlHelper.ExecuteDataset(cs, "Getkupci");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Kupac
                {
                    IDKupac = (int)row["IDKupac"],
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    GradID = row["GradID"] != DBNull.Value ? (int)row["GradID"] : 1
                };
            }

        }



        public static Kupac GetKupac(int IDKupac)
        {
            return GetKupci().Single(k => k.IDKupac == IDKupac);
        }

        public static Grad GetGrad(int IDGrad)
        {
            DataRow row = SqlHelper.ExecuteDataset(cs, "GetGrad", IDGrad).Tables[0].Rows[0];
            return new Grad
            {
                IDGrad = (int)row["IDGrad"],
                Naziv = row["Naziv"].ToString(),
                DrzavaID = (int)row["DrzavaID"]
            };
        }



        public static int UpdateKupac(Kupac kupac)
        {
            return SqlHelper.ExecuteNonQuery(cs, "UpdateKupac", kupac.IDKupac, kupac.Ime, kupac.Prezime, kupac.Email, kupac.Telefon, kupac.GradID);
        }

        public static List<Grad> GetGradovi()
        {
            List<Grad> kolekcija = new List<Grad>();

            ds = SqlHelper.ExecuteDataset(cs, "GetGradovi");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                kolekcija.Add(new Grad
                {
                    IDGrad = (int)row["IDGrad"],
                    Naziv = row["Naziv"].ToString()
                });
            }
            return kolekcija;
        }

        public static Drzava GetDrzava(int GradID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetDrzava", GradID);
            DataRow row = ds.Tables[0].Rows[0];

            Drzava d = new Drzava();
            d.IDDrzava = (int)row["IDDrzava"];
            d.Naziv = row["Naziv"].ToString();

            return d;
        }

        public static IEnumerable<Drzava> GetDrzave()
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetDrzave");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Drzava
                {
                    IDDrzava = (int)row["IDDrzava"],
                    Naziv = row["Naziv"].ToString()
                };
            }
        }

        public static IEnumerable<Racun> GetRacuniForKupac(int kupacID)
        {

            ds = SqlHelper.ExecuteDataset(cs, "GetRacuniForKupac", kupacID);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Racun
                {
                    IDRacun = (int)row["IDRacun"],
                    DatumIzdavanja = DateTime.Parse(row["DatumIzdavanja"].ToString()),
                    BrojRacuna = row["BrojRacuna"].ToString(),
                    Komercijalist = row["KomercijalistID"] != DBNull.Value ? new Komercijalist { IDKomercijalist = (int)row["KomercijalistID"], Ime = row["Ime"].ToString(), Prezime = row["Prezime"].ToString() } : new Komercijalist { IDKomercijalist = 0, Ime = "/", Prezime = "/" },
                    KreditnaKartica = row["KreditnaKarticaID"] != DBNull.Value ? new KreditnaKartica { IdKreditnaKartica = (int)row["KomercijalistID"], Tip = row["Tip"].ToString() } : new KreditnaKartica { IdKreditnaKartica = -1, Tip = "Gotovina" },
                    Komentar = row["Komentar"] != DBNull.Value ? row["Komentar"].ToString() : "-"
                };
            }

        }

        public static Racun GetRacun(int IDRacun)
        {

            ds = SqlHelper.ExecuteDataset(cs, "GetRacun", IDRacun);
            DataRow row = ds.Tables[0].Rows[0];
            return new Racun
            {
                IDRacun = (int)row["IDRacun"],
                DatumIzdavanja = DateTime.Parse(row["DatumIzdavanja"].ToString()),
                BrojRacuna = row["BrojRacuna"].ToString(),
                Komercijalist = row["KomercijalistID"] != DBNull.Value ? new Komercijalist { IDKomercijalist = (int)row["KomercijalistID"], Ime = row["Ime"].ToString(), Prezime = row["Prezime"].ToString() } : new Komercijalist { IDKomercijalist = 0, Ime = "/", Prezime = "/" },
                KreditnaKartica = row["KreditnaKarticaID"] != DBNull.Value ? new KreditnaKartica { IdKreditnaKartica = (int)row["KomercijalistID"], Tip = row["Tip"].ToString() } : new KreditnaKartica { IdKreditnaKartica = -1, Tip = "Gotovina" },
                Komentar = row["Komentar"] != DBNull.Value ? row["Komentar"].ToString() : "-"
            };

        }

        public static IEnumerable<Potkategorija> GetPotkategorije()
        {

            ds = SqlHelper.ExecuteDataset(cs, "GetPotkategorije");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Potkategorija
                {
                    IDPotkategorija = (int)row["IDPotkategorija"],
                    KategorijaID = row["KategorijaID"] != DBNull.Value ? (int)row["KategorijaID"] : 0,
                    Naziv = row["Naziv"].ToString()
                };
            }

        }

        public static Potkategorija GetPotkategorija(int id)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetPodkategorija", id);
            DataRow row = ds.Tables[0].Rows[0];

            return new Potkategorija
            {
                IDPotkategorija = (int)row["IDPotkategorija"],
                KategorijaID = row["KategorijaID"] != DBNull.Value ? (int)row["KategorijaID"] : 0,
                Naziv = row["Naziv"].ToString()
            };
        }

        public static int UpdatePotkategorija(Potkategorija potkategorija)
        {
            return SqlHelper.ExecuteNonQuery(cs, "UpdatePodkategorija", potkategorija.IDPotkategorija, potkategorija.Naziv, potkategorija.KategorijaID);
        }

        public static int CreatePotkategorija(Potkategorija potkategorija)
        {
            return SqlHelper.ExecuteNonQuery(cs, "InsertPodkategorija", potkategorija.Naziv, potkategorija.KategorijaID);
        }

        public static int DeletePotkategorija(int id)
        {
            return SqlHelper.ExecuteNonQuery(cs, "DeletePodkategorija", id);
        }

        public static IEnumerable<Kategorija> GetKategorije()
        {

            ds = SqlHelper.ExecuteDataset(cs, "GetKategorije");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Kategorija
                {
                    IDKategorija = (int)row["IDKategorija"],
                    Naziv = row["Naziv"].ToString()
                };
            }

        }

        public static Kategorija GetKategorija(int id)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetKategorija", id);
            DataRow row = ds.Tables[0].Rows[0];
            return new Kategorija
            {
                IDKategorija = (int)row["IDKategorija"],
                Naziv = row["Naziv"].ToString()
            };
        }

        public static int UpdateKategorija(Kategorija kategorija)
        {
            return SqlHelper.ExecuteNonQuery(cs, "UpdateKategorija", kategorija.IDKategorija, kategorija.Naziv);
        }

        public static int CreateKategorija(Kategorija kategorija)
        {
            return SqlHelper.ExecuteNonQuery(cs, "InsertKategorija", kategorija.Naziv);
        }

        public static int DeleteKategorija(int id)
        {
            return SqlHelper.ExecuteNonQuery(cs, "DeleteKategorija", id);
        }

        public static IEnumerable<Stavka> GetStavke(int racunID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetStavkeForRacun", racunID);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Stavka
                {
                    IDStavka = (int)row["IDStavka"],
                    Kolicina = (short)row["Kolicina"],
                    CijenaPoKomadu = (decimal)row["CijenaPoKomadu"],
                    PopustUPostotcima = (decimal)row["PopustUPostocima"],
                    UkupnaCijena = (decimal)row["UkupnaCijena"],
                    ProizvodId = (int)row["ProizvodID"]

                };
            }
        }

        public static IEnumerable<Proizvod> GetProizvodi()
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetProizvodi");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Proizvod
                {
                    IDProizvod = (int)row["IDProizvod"],
                    Naziv = row["Naziv"].ToString(),
                    BrojProizvoda = row["BrojProizvoda"].ToString(),
                    Boja = row["Boja"] != DBNull.Value ? row["Boja"].ToString() : "/",
                    MinimalnaKolicinaNaSkladistu = (short)row["MinimalnaKolicinaNaSkladistu"],
                    CijenaBezPDV = (decimal)row["CijenaBezPDV"],
                    PodkategorijaId = (int)row["PotkategorijaID"],
                };
            }
        }

        public static Proizvod GetProizvod(int id)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetProizvod", id);
            DataRow row = ds.Tables[0].Rows[0];

            return new Proizvod
            {
                IDProizvod = (int)row["IDProizvod"],
                Naziv = row["Naziv"].ToString(),
                BrojProizvoda = row["BrojProizvoda"].ToString(),
                Boja = row["Boja"] != DBNull.Value ? row["Boja"].ToString() : "/",
                MinimalnaKolicinaNaSkladistu = (short)row["MinimalnaKolicinaNaSkladistu"],
                CijenaBezPDV = (decimal)row["CijenaBezPDV"],
                PodkategorijaId = (int)row["PotkategorijaID"],
            };

        }

        public static int CreateProizvod(Proizvod proizvod)
        {
            return SqlHelper.ExecuteNonQuery(cs, "CreateProizvod", proizvod.Naziv, proizvod.BrojProizvoda, proizvod.Boja, proizvod.MinimalnaKolicinaNaSkladistu, proizvod.CijenaBezPDV, proizvod.PodkategorijaId);
        }

        public static int UpdateProizvod(Proizvod proizvod)
        {
            return SqlHelper.ExecuteNonQuery(cs, "UpdateProizvod", proizvod.IDProizvod, proizvod.Naziv, proizvod.BrojProizvoda, proizvod.Boja, proizvod.MinimalnaKolicinaNaSkladistu, proizvod.CijenaBezPDV, proizvod.PodkategorijaId);
        }

        public static int DeleteProizvod(int id)
        {
            return SqlHelper.ExecuteNonQuery(cs, "DeleteProizvod", id);
        }

    }
}