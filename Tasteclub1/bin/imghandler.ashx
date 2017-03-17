<%@ WebHandler Language="C#" Class="imghandler" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public class imghandler : IHttpHandler
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());

    public void ProcessRequest(HttpContext context)
    {
        //string a = "" + context.Session["bi"].ToString();
        try
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select image from food_display where img_id= " + context.Request.QueryString["bookid"], con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                byte[] image = (byte[])(dr["image"]);
                context.Response.ContentType = "image/jpg || image/png || image/gif";
                context.Response.BinaryWrite(image);

            }

            if (dr != null)
            {


                dr.Close();
            }
        }
        finally
        {
            if (con != null)
                con.Close();
        }

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}