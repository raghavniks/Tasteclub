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

    


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
            if (txtpassword.Text == txtconfpass.Text)
            {
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                SqlCommand cmd1 = new SqlCommand("insert into admin_login values(@name, @password, @Designation)", con1);
                con1.Open();
                cmd1.Parameters.AddWithValue("@name", txtname.Text);
                //cmd1.Parameters.AddWithValue("@Email", txtemail.Text);
                //cmd1.Parameters.AddWithValue("@Contact", txtcontact.Text);
                cmd1.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd1.Parameters.AddWithValue("@Designation", txtdesig.Text);
                cmd1.ExecuteNonQuery();
              //  ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Successfully Add')</script>");

                txtname.Text = "";
               // txtemail.Text = "";
               // txtcontact.Text = "";
                txtpassword.Text = "";
                txtdesig.Text = "";
                txtconfpass.Text = "";
                lblMsg.Text = "User Register Successfully.";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                con1.Close();
                Response.Redirect(Request.Url.ToString(), false);
                
            }
            else
            {

                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Password Not Match')</script>");
                txtpassword.Text = "";
                txtconfpass.Text = "";

            }
        
        
    

        //}
        
        
    }


        //protected void txtpname_TextChanged(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["test"].ToString());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select * from Add_User where Name='" + txtpname.Text + "'", con);
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.Read())
        //    {
        //        Label1.Text = "User Name is Already Exist";
        //        txtpname.Text = "";
            
        //    }
        //    else
        //    {
        //        Label1.Text = "UserName is Available";
            
        //    }
        //    con.Close();
        //}
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
       // txtemail.Text = "";
       // txtcontact.Text = "";
        txtpassword.Text = "";
        txtconfpass.Text = "";
       // txtdesig.Text = "";

    }
    protected void txtname_TextChanged(object sender, EventArgs e)
    {
    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    //    con.Open();
    //  SqlCommand cmd=new SqlCommand("select name from admin_login where name='" + txtname.Text + "'", con);
    //  SqlDataReader dr = cmd.ExecuteReader();
    //   if (dr.Read())
    //   {
    //       Label2.Text = "User Name Already Exist";
    //   }
    //   else
    //   {
    //       Label2.Text = "User Name Available";
    //   }
    //   con.Close();
    }
    protected void txtpassword_TextChanged(object sender, EventArgs e)
    {

    }
}
 




    

