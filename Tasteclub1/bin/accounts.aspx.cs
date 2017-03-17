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
        //lbname.Text = Session["s"].ToString();

        lbname.Text = Session["firstname"].ToString();

        Label12.Text = Session["firstname"].ToString();

        Label4.Text = Session["email"].ToString();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from location where email='" + Session["email"] + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            //Label2.Text = dr["fstname"].ToString();
           // Label4.Text = dr["email"].ToString();
            Label15.Text = dr["location"].ToString();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        conn.Open();
        SqlCommand cmdd = new SqlCommand("select * from login where email='" + Session["email"] + "'", conn);
        SqlDataReader drr = cmdd.ExecuteReader();
        if (drr.Read())
        {
            Label6.Text = drr["phone"].ToString();

        }
    }
}