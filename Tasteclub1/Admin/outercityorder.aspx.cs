using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Admin_Default2 : System.Web.UI.Page
{  SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
      
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv();
        }
    }

    private void gv()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM outercityorder ", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
}