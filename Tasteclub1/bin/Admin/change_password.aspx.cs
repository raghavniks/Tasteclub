using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd=new SqlCommand("select * from admin_login where name='" + Textnam.Text + "' AND password='" + Textoldpass.Text + "'", con);
        SqlDataReader dr=cmd.ExecuteReader();

        if (dr.Read())
        {
            
                if (Textnewpass.Text == Textconpass.Text)
                {
                    SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                    con2.Open();
                    SqlCommand cmd2 = new SqlCommand("update admin_login set password=@password where name='" + Textnam.Text + "'", con2);
                    cmd2.Parameters.AddWithValue("@password", Textnewpass.Text);
                    cmd2.ExecuteNonQuery();
                    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password Change Successfully')</script>");
                    Textnam.Text = "";
                    Textoldpass.Text = "";
                    Textnewpass.Text = "";
                    Textconpass.Text = "";
                    lbmsg.Text = "Change Password Successfully.";
                    lbmsg.ForeColor = System.Drawing.Color.Green;
                    con2.Close();
                }
                else
                {
                    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password Must be Match.')</script>");
                    lbmsg.Text = "Something is Going Wrong, Check It Carefully.";
                    lbmsg.ForeColor = System.Drawing.Color.Red;
                 
                }





                con.Close();
             
        }
        else
        {
            //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User Name Not Exist or Old Password is Incorrect.')</script>");

            Textnam.Text = "";
            Textoldpass.Text = "";
            lbmsg.Text = "User Not Exist.";
            lbmsg.ForeColor = System.Drawing.Color.Green;
        }
        
        
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        Textnam.Text = "";
        Textoldpass.Text = "";
        Textnewpass.Text = "";
        Textconpass.Text = "";
    }
}