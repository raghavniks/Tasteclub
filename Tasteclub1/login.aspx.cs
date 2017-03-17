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
    string email;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

        //try
        //{


            if (!IsPostBack)
            {
                Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                if (email != "")
                {
                    mail();
                }
                else
                {
                    Response.Redirect("~/new_meting.aspx");
                }

            }
        //}

        //catch (Exception e1)
        //{ ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again')</script>"); }
    }
    private void mail()
    {
        con.Open();
        email = Request.QueryString["a"];
        TextBox1.Text = email;
        if (TextBox1.Text != "")
        {
            Label3.Text = "This Email Already Exists. Please Register With A New One.";
            Label3.ForeColor = System.Drawing.Color.Red;
            Label3.Attributes.Add("Style", "font-size:18px;");
        }
        else
        {
            Label3.Text = "";
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

        //try
        //{
            con.Open();

            Session["currentpanel"] = "0";
            Session["currentpanel1"] = "0";
            Session["currentpanel2"] = "0";
            Session["currentpanel3"] = "0";
            Session["currentpanel4"] = "0";




            SqlCommand cmd1 = new SqlCommand("select password from login where email='" + TextBox1.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                if (TextBox2.Text == dr1["password"].ToString())
                {
                    dr1.Close();
                    SqlCommand cmd = new SqlCommand("select * from login where email='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string snm = dr["fstname"].ToString();
                        string snm1 = dr["email"].ToString();


                        Session["s"] = snm;
                        Session["e"] = snm1;


                        Session["firstname"] = dr["fstname"].ToString();
                        Session["lastname"] = dr["lastname"].ToString();
                        Session["email"] = dr["email"].ToString();
                        Session["phone"] = dr["phone"].ToString();


                        dr.Close();

                        SqlCommand cmddelete = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
                        cmddelete.ExecuteNonQuery();

                        SqlCommand cmdtemp = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
                        cmdtemp.ExecuteNonQuery();


                        Session["login"] = 1;

                        SqlCommand cmd2 = new SqlCommand("select [region],[companyname],[location] from [location] where email='" + TextBox1.Text + "'", con);

                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            Session["city"] = dr2["region"].ToString();
                            Session["companyname"] = dr2["companyname"].ToString();
                            Session["location"] = dr2["location"].ToString();
                            dr2.Close();
                        }
                        else
                        {
                            dr2.Close();
                        }


                        Response.Redirect("~/new_meting.aspx");
                    }
                    else
                    {

                        dr.Close();
                    }

                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Username Or Password Mismatch.')</script>");
                    dr1.Close();
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('No Records Available.')</script>");
                dr1.Close();
            }
            con.Close();
        //}

        //catch (Exception e2)
        //{ 
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>"); 
        //   // Response.Redirect("~/login.aspx"); 
        //}


      
    }
  
}