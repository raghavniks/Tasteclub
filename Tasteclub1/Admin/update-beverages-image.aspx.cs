using System;
using System.Collections.Generic;
using System.Linq;
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
        SqlDataAdapter da = new SqlDataAdapter("SELECT itemname, img_id FROM beverages", con1);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DropDownList1.DataSource = ds;
        DropDownList1.DataTextField = "itemname";
        DropDownList1.DataValueField = "img_id";
        DropDownList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con1.Open();
        SqlCommand cmd = new SqlCommand("select * from beverages where img_id='" + DropDownList1.SelectedValue + "'", con1);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["img_id"].ToString();
            TextBox2.Text = dr["itemname"].ToString();
            TextBox3.Text = dr["companyname"].ToString();
            TextBox4.Text = dr["price"].ToString();
            TextBox5.Text = dr["des"].ToString();
            TextBox6.Text = dr["alle"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Byte[] bytes = null;

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlCommand cmd1 = new SqlCommand("update beverages set img=@img, itemname=@itemname, des=@des, alle=@alle, companyname=@companyname, price=@price where img_id='" + TextBox1.Text + "'", con1);
        con1.Open();
        if (FileUpload1.HasFile)
        {
            string filename = FileUpload1.PostedFile.FileName;
            string filePath = Path.GetFileName(filename);

            Stream fs = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            bytes = br.ReadBytes((Int32)fs.Length);
        }
        cmd1.Parameters.AddWithValue("@img", bytes);
        cmd1.Parameters.AddWithValue("@itemname", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@des", TextBox5.Text);
        cmd1.Parameters.AddWithValue("@alle", TextBox6.Text);
        cmd1.Parameters.AddWithValue("@companyname", TextBox3.Text);
        cmd1.Parameters.AddWithValue("@price", TextBox4.Text);
 

        cmd1.ExecuteNonQuery();
     
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox6.Text = "";
      
        lbmsg.Text = "Update Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        Response.Redirect(Request.Url.ToString(), false);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlCommand cmd1 = new SqlCommand("delete from beverages where img_id='" + TextBox1.Text + "'", con1);
        con1.Open();
        cmd1.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox6.Text = "";
     
        lbmsg.Text = "Delete Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        Response.Redirect(Request.Url.ToString(), false);
        con1.Close();
    }
}