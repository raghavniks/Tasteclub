using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class user_res_loc : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        //lbnam.Text = "" + Request.QueryString["nam"];
        //Labelname.Text = "" + Request.QueryString["nam"];
        //Labelemail.Text = "" + Request.QueryString["email"];
        //Labelphone.Text = "" + Request.QueryString["phn"];

        lbnam.Text = Session["firstname"].ToString();
        Labelname.Text = Session["firstname"].ToString();
        Labelemail.Text = Session["email"].ToString();
        Labelphone.Text=Session["phone"].ToString();


        if (!IsPostBack)
        {
            lblcity.Visible = false;
            lbladdress.Visible = false;
            lblcompany.Visible = false;
            lblcompanyaddress.Visible = false;
            dl();
            dlvalue1();
            Reset();
            ddcompany.Items.Insert(0, new ListItem("Select Company", "0"));
            ddaddress.Items.Insert(0, new ListItem("Select Address", "0"));

        }
      
    }
    private void Reset()
    {
        txtcity.Text = "";
        txtaddress.Text ="";
        lblmsg.Text = "";
    }


    private void dl()
    {
        DataSet ds = new DataSet();
        ds.Tables.Clear();

       
        con.Open();
        SqlDataAdapter cmd = new SqlDataAdapter("select * from company ", con);
        cmd.Fill(ds);
        ddcompany.DataSource = ds.Tables[0];
        ddcompany.DataValueField = "company_name";
        ddcompany.DataBind();

    }
    private void dlvalue1()
    {
        DropDownList1.Visible = true;
        ddcompany.Visible = false;
        ddaddress.Visible = false;
        txtcity.Visible = false;
        txtaddress.Visible = false;
    }
    private void dlvalue()
    {
        if (DropDownList1.Text == "-----Choose a Region-----")
        {
            ddcompany.Visible = false;
            ddaddress.Visible = false;
            txtcity.Visible = false;
            txtaddress.Visible = false;
            lblcity.Visible = false;
            lbladdress.Visible = false;
            lblcompany.Visible = false;
            lblcompanyaddress.Visible = false;
        }
        else if (DropDownList1.Text == "Gurgaon")
        {
            ddcompany.Visible = true;
            ddaddress.Visible = true;
            txtcity.Visible = false;
            txtaddress.Visible = false;
            lblcity.Visible = false;
            lbladdress.Visible = false;
            lblcompany.Visible = true;
            lblcompanyaddress.Visible = true;
        }
        else if (DropDownList1.Text == "Other City")
        {
            ddcompany.Visible = false;
            ddaddress.Visible = false;
            txtcity.Visible = true;
            txtaddress.Visible = true;
            lblcity.Visible = true;
            lbladdress.Visible = true;
            lblcompany.Visible = false;
            lblcompanyaddress.Visible = false;
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //con.Open();
        //SqlCommand cmd1 = new SqlCommand("delete food_order", con);
        //cmd1.ExecuteNonQuery();

        //SqlCommand cmd2 = new SqlCommand("delete location", con);
        //cmd2.ExecuteNonQuery();

        //SqlCommand cmd3 = new SqlCommand("delete register", con);
        //cmd3.ExecuteNonQuery();

        //SqlCommand cmd4 = new SqlCommand("delete payment", con);
        //cmd4.ExecuteNonQuery();

        //SqlCommand cmd5 = new SqlCommand("delete networking", con);
        //cmd5.ExecuteNonQuery();

        //con.Close();
        if (DropDownList1.SelectedItem.Text == "-----Choose a Region-----" && txtcity.Visible == false && txtaddress.Visible == false)
        {
            lblmsg.Text = "";
            ddaddress.Visible = false;
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('please select city from the List.')</script>");
        }


        else if (DropDownList1.SelectedItem.Text == "Gurgaon" && txtcity.Visible == false && txtaddress.Visible == false)
        {
            lblmsg.Text = "";
            if (ddcompany.SelectedItem.Text == "Select Company" || ddaddress.SelectedItem.Text == "Select Address")
            {
                lblmsg.Text = "please fill company name and address";
            }
            else
            {
                lblmsg.Text = "";
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into location values('" + lbnam.Text + "','" + Labelemail.Text + "','" + DropDownList1.SelectedItem.Text + "','" + ddcompany.SelectedItem.Text + "','" + ddaddress.Text + "')", con);
                cmd.ExecuteNonQuery();
                Reset();
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Successfully Register')</script>");

                //Session["s"] = lbnam.Text;
                //Session["e"] = Labelemail.Text;
                //Session["phone"]=Labelphone.Text;
                Session["location"] = ddaddress.SelectedItem.Text;
                Session["city"] = DropDownList1.SelectedItem.Text;
                Session["login"] = 1;
                Response.Redirect("new_meting.aspx");
            }
        }

        else if (DropDownList1.SelectedItem.Text == "-----Choose a Region-----" && txtcity.Visible == true && txtaddress.Visible == true && txtcity.Text == "" && txtaddress.Text == "")
        {
            lblmsg.Text = "";
            ddaddress.Visible = false;
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('please fill your address with city')</script>");
        }

        else if (DropDownList1.SelectedItem.Text == "-----Choose a Region-----" && txtcity.Text != "" && txtaddress.Text != "")
        {
            lblmsg.Text = "";
            con.Open();
            ddaddress.Visible = false;
            SqlCommand cmd = new SqlCommand("insert into outercityorder values('" + Request.QueryString["fstname"] + "','" + Request.QueryString["lstname"] + "','" + Labelemail.Text + "','" + txtcity.Text + "','" + txtaddress.Text + "','" + DateTime.Now.Date.ToShortDateString() + "')", con);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("delete login where email='" + Labelemail.Text + "'", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            Reset();
            lblmsg.Text = "currently we are not serving in this city but your address is succesfully saved for future.";

        }
        else if (DropDownList1.SelectedItem.Text == "Gurgaon" && txtcity.Visible == true && txtaddress.Visible == true)
        {
            lblmsg.Text = "";
            txtcity.Visible = false;
            txtaddress.Visible = false;
            lblcity.Visible = false;
            lbladdress.Visible = false;

            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('You selected gurgaon city')</script>");
        }
        else
        {
            lblmsg.Text = "";
        }
    }



    protected void ddloption_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        DataSet ds1 = new DataSet();
        SqlDataAdapter cmd1 = new SqlDataAdapter("select address from address where company_name='" + ddcompany.SelectedItem.Text + "'", con);
        cmd1.Fill(ds1);
        ddaddress.DataSource = ds1.Tables[0];
        ddaddress.DataValueField = "address";
        ddaddress.DataBind();
        ddaddress.Items.Insert(0, new ListItem("Select Address", "0"));
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dlvalue();
        Reset();
    }
    protected void ddaddress_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddcompany.AutoPostBack = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (txtcity.Visible == true && txtaddress.Visible == true && DropDownList1.Text !="")
        {
            txtcity.Visible = false;
            txtaddress.Visible = false;
            lblcity.Visible = false;
            lbladdress.Visible = false;
        }
        else
        {
            txtcity.Visible = true;
            txtaddress.Visible = true;
            lblcity.Visible = true;
            lbladdress.Visible = true;
        }
    }
}