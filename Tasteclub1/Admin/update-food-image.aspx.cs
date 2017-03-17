using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            drop();
        }
    }

    private void drop()
    {

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("SELECT itemname, img_id FROM food_display", con1);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DropDownList3.DataSource = ds;
        DropDownList3.DataTextField = "itemname";
        DropDownList3.DataValueField = "img_id";
        DropDownList3.DataBind();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con1.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where img_id='"+DropDownList3.SelectedValue+"'", con1);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            txtid.Text = dr["img_id"].ToString();
            TextBox1.Text = dr["itemname"].ToString();
            TextBox2.Text = dr["companyname"].ToString();
            TextBox3.Text = dr["price"].ToString();
            DropDownList1.Text=dr["veg"].ToString();
            DropDownList2.Text = dr["day"].ToString();
            TextBox4.Text = dr["description"].ToString();
            TextBox5.Text = dr["Allergance"].ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Byte[] bytes = null;

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlCommand cmd1 = new SqlCommand("update food_display set image=@image, itemname=@itemname, description=@description, Allergance=@Allergance, companyname=@companyname, price=@price, veg=@veg, day=@day where img_id='"+txtid.Text+"'", con1);
        con1.Open();
        if (FileUpload1.HasFile)
        {
            string filename = FileUpload1.PostedFile.FileName;
            string filePath = Path.GetFileName(filename);

            Stream fs = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            bytes = br.ReadBytes((Int32)fs.Length);
        }
        cmd1.Parameters.AddWithValue("@image", bytes);
        cmd1.Parameters.AddWithValue("@itemname", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@description", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@Allergance", TextBox5.Text);
        cmd1.Parameters.AddWithValue("@companyname", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@price", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@veg", DropDownList1.SelectedItem.Text);
        cmd1.Parameters.AddWithValue("@day", DropDownList2.SelectedItem.Text);

        cmd1.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        DropDownList1.Text = "---Select---";
        DropDownList2.Text = "---Select---";
        lbmsg.Text = "Update Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        Response.Redirect(Request.Url.ToString(), false);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlCommand cmd1 = new SqlCommand("delete from food_display where img_id='"+txtid.Text+"'", con1);
        con1.Open();
        cmd1.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        DropDownList1.Text = "---Select---";
        DropDownList2.Text = "---Select---";
        lbmsg.Text = "Delete Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        Response.Redirect(Request.Url.ToString(), false);
        con1.Close();
    }
}