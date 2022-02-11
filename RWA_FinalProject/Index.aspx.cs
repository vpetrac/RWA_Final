using RWA_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RWA_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        IEnumerable<Grad> cities;
        IEnumerable<Drzava> countries;
        string command;
        int currentCountryId;
        int currentCityId;
        protected void Page_Load(object sender, EventArgs e)
        {

            

            countries = Repo.GetDrzave();
            cities = Repo.GetGradovi();

            foreach (var country in countries)
            {
                filter_country.Items.Add(new ListItem { Text = country.Naziv, Value = country.IDDrzava.ToString() });
            }

            foreach (var city in cities)
            {
                filter_city.Items.Add(new ListItem { Text = city.Naziv, Value = city.IDGrad.ToString() });
            }

        }

        protected void filter_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter_country.SelectedIndex > 0) currentCountryId = int.Parse(filter_country.SelectedValue);
            else currentCountryId = -1;

            /*
            if (filter_country.SelectedIndex != 0)
            {
                filter_city.Items.Clear();
                filter_city.Items.Add("Svi gradovi");
                cities = Repo.GetGradovi();
                cities.RemoveAll(city => city.DrzavaID != currentCountryId);
                foreach (var city in cities)
                {
                    filter_city.Items.Add(new ListItem { Text = city.Naziv, Value = city.IDGrad.ToString() });

                }
                
                filter_city.SelectedIndex = 1;
                currentCityId = int.Parse(filter_city.Items[1].Value);
            }
            */

            
        }

        protected void filter_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter_city.SelectedIndex > 0) currentCityId = int.Parse(filter_city.SelectedValue);
            else currentCityId = -1;
            SqlDataSource1.SelectCommand = $"SELECT Kupac.IDKupac, Kupac.Ime, Kupac.Prezime, Kupac.Email, Kupac.Telefon, Grad.Naziv, Drzava.Naziv AS Expr1, Kupac.GradID FROM Kupac INNER JOIN Grad ON Kupac.GradID = Grad.IDGrad INNER JOIN Drzava ON Grad.DrzavaID = Drzava.IDDrzava where Kupac.GradID={currentCityId}";
        }

        protected void filter_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter_size.SelectedValue != null)
            {
                GridView1.PageSize = int.Parse(filter_size.SelectedValue);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        
    }
}