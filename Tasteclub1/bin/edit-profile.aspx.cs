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
       // lbname.Text = Session["s"].ToString();
        lbname.Text = Session["email"].ToString();
        TextBox1.Text = Session["firstname"].ToString();
        TextBox2.Text = Session["lastname"].ToString();
        TextBox3.Text = Session["email"].ToString();
        TextBox4.Text = Session["phone"].ToString();

        if (!IsPostBack)
        {
           // update();
        }
    }


    private void update()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from login where email='" + Session["email"] + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["fstname"].ToString();
            TextBox2.Text = dr["lastname"].ToString();
            TextBox3.Text = dr["email"].ToString();
            Label5.Text = dr["id"].ToString();
            TextBox4.Text = dr["phone"].ToString();
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Label16.Text = "";
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("update login set fstname='" + TextBox1.Text + "', lastname='" + TextBox2.Text + "', email='" + TextBox3.Text + "', phone='" + TextBox4.Text + "' where id='" + Label5.Text + "'", con);
    
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        Label16.Text = "update successfully";
    }
   
}