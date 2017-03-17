using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage3 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbname.Text = Session["s"].ToString();
        if (!IsPostBack)
        {
            if (Session["login"].ToString() == "1") { }
            else { Response.Redirect("~/login.aspx"); }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["login"] = "0";
        Response.Redirect("~/login.aspx");
    }
}
