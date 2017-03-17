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
    string l;
    protected void Page_Load(object sender, EventArgs e)
    {
        l = Request.QueryString["n"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == TextBox2.Text)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("update login set password=@password where email='" + l + "'", con);
            cmd.Parameters.AddWithValue("@password", TextBox1.Text);
            cmd.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
            // Label l1 = new Label();
            l1.Text = "Password Reset Successfully";
            l1.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            //Label l1 = new Label();
            l1.Text = "Password doesn,t Match.";
            l1.ForeColor = System.Drawing.Color.Green;
        }
    }
}