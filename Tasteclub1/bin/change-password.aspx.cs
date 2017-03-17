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
      //  lbname.Text = Session["s"].ToString();
        lbname.Text = Session["email"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lblmsg.Text = "";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        conn.Open();
        SqlCommand cmdd = new SqlCommand("select password from login where email='" + Session["email"] + "' and password='" + TextBox1.Text + "'", conn);
        SqlDataReader dr = cmdd.ExecuteReader();
        if (dr.Read())
        {
            if (TextBox2.Text == TextBox3.Text)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("update login set password=@password where email='" + Session["email"] + "'", con);
                cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                lblmsg.Text = "Update Successfully";
                //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Update Successfully')</script>");
                con.Close();
            }
            else
            {
                lblmsg.Text = "Password does not Match.";
                //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password does not Match.')</script>");
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }
        else
        {
            lblmsg.Text = "Your Password Is Not Correct.";
            //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Your Password Is Not Correct.')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}