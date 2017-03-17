using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class user_res : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Password = TextBox3.Text;
        TextBox3.Attributes.Add("value", Password);
        string Password1 = TextBox12.Text;
        TextBox12.Attributes.Add("value", Password1);
        Panel1.Visible = false;
        Panel2.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        //con.Open();
        //SqlCommand cmd = new SqlCommand("select * from login where name='"+TextBox1.Text+"' AND password='"+TextBox2.Text+"'", con);
        //SqlDataReader dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    Response.Redirect("~/new_meting.aspx?s=" + TextBox1.Text + "");
        //}
        //else
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('No user Exist.')</script>");
        //}

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/new_meting.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBox3.Text == TextBox12.Text)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into register values(@name, @email, @password, @c_name, @location)", con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@password", TextBox3.Text);
            cmd.Parameters.AddWithValue("@c_name", TextBox4.Text);
            cmd.Parameters.AddWithValue("@location", TextBox5.Text);
            cmd.ExecuteNonQuery();

            if (DropDownList2.SelectedItem.Text == "Networking")
            {
                cmd = new SqlCommand("insert into networking values(@name, @email, @card, @bankname, @branch)", con);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@card", DropDownList2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@bankname", TextBox10.Text);
                cmd.Parameters.AddWithValue("@branch", TextBox11.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {

                cmd = new SqlCommand("insert into payment values(@name, @email, @card, @cardno, @cvv, @expirydate, @name_on_card)", con);
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@card", DropDownList2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@cardno", TextBox7.Text);
                cmd.Parameters.AddWithValue("@cvv", TextBox8.Text);
                cmd.Parameters.AddWithValue("@expirydate", TextBox6.Text);
                cmd.Parameters.AddWithValue("@name_on_card", TextBox9.Text);
                cmd.ExecuteNonQuery();
            }

            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Successfully Registered')</script>");
            TextBox1.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedItem.Text == "Networking")
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
        }
        else
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
        }
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        if (TextBox3.Text != TextBox12.Text)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password doesn't Match.')</script>");
        }
    }
}