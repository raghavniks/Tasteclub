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

        //lbname.Text = Session["s"].ToString();


       lbname.Text = Session["firstname"].ToString();
 

        if (!IsPostBack)
        {
          //  get();
            drop();
          
        }
    }

    private void get()
    {
        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con1.Open();
        SqlCommand cmd = new SqlCommand("select email from login where fstname='" + lbname.Text + "'", con1);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            lbemail.Text = dr[0].ToString();
            con1.Close();
        }
    }

    private void drop()
    {

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con1.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM temp where fstname='" + Session["firstname"] + "' AND email='" + Session["email"] + "' ", con1);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM temp where fstname='" + Session["firstname"] + "' AND email='" + Session["email"] + "' ", con1);
            // da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;

            GridView1.DataBind();
            con1.Close();
        }
        else
        {
            lbnorecord.Text = "No Active Orders Found.";
            lbnorecord.ForeColor = System.Drawing.Color.Green;
            con1.Close();
        }

    }
}