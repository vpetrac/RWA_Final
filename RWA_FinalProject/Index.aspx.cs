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
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login");
            }

        
        }

   
        
        protected void filter_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        protected void filter_country_DataBound(object sender, EventArgs e)
        {

            filter_city.Items.Insert(0, new ListItem("--SELECT--", "0"));
        }

        protected void filter_city_DataBound(object sender, EventArgs e)
        {
            //filter_city.Items.Insert(0, new ListItem("Odaberi grad"));
        }
    }
}