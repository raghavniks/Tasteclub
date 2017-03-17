using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select email from login where email='"+txtemail.Text+"'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
           
            Response.Redirect("~/login.aspx?a="+txtemail.Text+"");
            dr.Close();
        }
        else
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into login values(@fstname, @lastname, @email, @password, @phone)", conn);
            string input = txtfstname.Text;
            input = Regex.Replace(input.ToLower(), @"\b[a-zA-Z]", m => m.Value.ToUpper());
            cmd1.Parameters.AddWithValue("fstname", input);
            string input1 = txtlastname.Text;
            input1 = Regex.Replace(input1.ToLower(), @"\b[a-zA-Z]", m => m.Value.ToUpper());
            cmd1.Parameters.AddWithValue("lastname", input1);
            cmd1.Parameters.AddWithValue("email", txtemail.Text);
            cmd1.Parameters.AddWithValue("password", txtpass.Text);
            cmd1.Parameters.AddWithValue("phone", txtph.Text);
            cmd1.ExecuteNonQuery();
            Session["firstname"] = input;
            Session["lastname"] = input1;
            Session["email"] = txtemail.Text;
            Session["password"] = txtpass.Text;
            Session["phone"] = txtph.Text;
           // Response.Redirect("~/user_res_loc.aspx?nam=" + input + "&email=" + txtemail.Text + "&fstname="+txtfstname.Text+"&lstname="+txtlastname.Text+"&phn="+txtph.Text+"");
            Response.Redirect("~/user_res_loc.aspx");
            txtfstname.Text = "";
            txtlastname.Text = "";
            txtpass.Text = "";
            txtemail.Text = "";
            txtph.Text = "";
            conn.Close();
        }
    }
}