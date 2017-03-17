using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {if (!IsPostBack){gd();}}
    public void gd()
    {SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
     con.Open();
     SqlDataAdapter da = new SqlDataAdapter("select * from temp", con);
     DataSet ds = new DataSet();
     da.Fill(ds);
     GridView1.DataSource = ds.Tables[0];
     GridView1.DataBind();
     con.Close();}
}