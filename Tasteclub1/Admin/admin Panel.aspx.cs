using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from admin_login where name='" + txtName.Text + "' AND password='" + txtPass.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            Response.Redirect("~/Admin/default_adm.aspx?s=" + txtName.Text + "");
        }
        else
        {
            lblmessage.Text = "no user exist";
        }
        con.Close();
       
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtPass.Text = "";
    }
}

  