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
     
       
        //txtname.Enabled = false;
        

        if (!IsPostBack)
        {

            fillddl();
        }

    }

    private void fillddl()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select distinct name from admin_login", con);
        da.Fill(ds);
        Ddlshow.DataSource = ds;
        Ddlshow.DataValueField = "name";
        Ddlshow.DataBind();
        con.Close();

    }

    protected void btndel_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand com = new SqlCommand("delete from admin_login where name= '" + txtname.Text + "'", con);
        com.ExecuteNonQuery();
        
      //  ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User Deleted Successfully.')</script>");

        txtname.Text = "";
        txtid.Text = "";
        txtdesig.Text = "";



        lbmsg.Text = "User Delete Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;

        SqlDataAdapter daa = new SqlDataAdapter("select distinct name from admin_login", con);
        DataSet das = new DataSet();
        daa.Fill(das);
        Ddlshow.DataSource = das;
        Ddlshow.DataValueField = "name";
        Ddlshow.DataBind();
       
     
        con.Close();
        
        
      

       

    }

    protected void Ddlshow_SelectedIndexChanged(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from admin_login where name = '" + Ddlshow.SelectedItem.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            //txtname.Enabled = true;


            txtname.Text = dr[1].ToString();
            txtid.Text = dr[0].ToString();
           
            txtdesig.Text = dr[3].ToString();

            

        }
        else
        {
            //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('No Such Record Exist.')</script>");

            lbmsg.Text = "User Register Successfully.";
            lbmsg.ForeColor = System.Drawing.Color.Green;
        }
        con.Close();


    }

    protected void btncancl_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtid.Text = "";
       
        txtdesig.Text = "";
    }
    protected void btnupd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("update admin_login set  name=@name, Designation=@Designation where id='" + txtid.Text + "'", con);
        cmd.Parameters.AddWithValue("@name", txtname.Text);
        //cmd.Parameters.AddWithValue("@Email", txtemail.Text);
        //cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);
        ////cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
        cmd.Parameters.AddWithValue("@Designation", txtdesig.Text);
        cmd.ExecuteNonQuery();
        //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Update Successfully')</script>");
        txtname.Text = "";
       // txtemail.Text = "";
        //txtpassword.Text = "";
       // txtcontact.Text = "";
        //txtconfpass.Text = "";
        txtdesig.Text = "";

        lbmsg.Text = "User Update Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        con.Close();


    }


   
}