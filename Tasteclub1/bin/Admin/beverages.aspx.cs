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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Byte[] bytes = null;

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        SqlCommand cmd1 = new SqlCommand("insert into beverages values(@img, @itemname, @companyname, @price, @des, @alle)", con1);
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
        cmd1.Parameters.AddWithValue("@itemname", TextBox3.Text);
      
    
        cmd1.Parameters.AddWithValue("@companyname", TextBox4.Text);
        cmd1.Parameters.AddWithValue("@price", TextBox5.Text);
        cmd1.Parameters.AddWithValue("@des", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@alle", TextBox2.Text);
   


        cmd1.ExecuteNonQuery();
        lbmsg.Text = "Add Images Successfully.";
        lbmsg.ForeColor = System.Drawing.Color.Green;
        //con1.Close();
        //lblMsg.Text = "Product Added Successfully.";
        // ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Food Added Successfully.')</script>");
    }
} 