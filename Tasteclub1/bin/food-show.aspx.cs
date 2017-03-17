using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbbookid.Text=Request.QueryString["bookid"];
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();

        SqlCommand cmd = new SqlCommand("Select * from food_display where img_id='" + lbbookid.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        { 
            string img=dr[0].ToString();
            Image1.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            lbrestro.Text=dr["companyname"].ToString();
            lbdes.Text = dr["description"].ToString();
            lballer.Text = dr["Allergance"].ToString();
        }
    }
}