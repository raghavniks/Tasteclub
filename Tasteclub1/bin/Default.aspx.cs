using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.IO;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    public string action1 = string.Empty;
    public string hash1 = string.Empty;
    public string txnid1 = string.Empty;

    string sub, sub1;
    string guid;
    protected void Page_Load(object sender, EventArgs e)
    {
        productinfo.Text = "TASTECLUB ORDERS";
        country.Text = "INDIA";
        zipcode.Text = "122001";
        state.Text = "HARYANA";

        if (HttpContext.Current.Session["email"] != null)
        {email.Text = Session["email"].ToString();// code if session is not null
        }
        else
        {email.Text = "email";// code if session is null
        }











        if (HttpContext.Current.Session["firstname"] != null)
        {firstname.Text = Session["firstname"].ToString();// code if session is not null
        }
        else
        {firstname.Text = "firstname";// code if session is null
        }














        if (HttpContext.Current.Session["phone"] != null)
        {phone.Text = Session["phone"].ToString();// code if session is not null
        }
        else
        {phone.Text = "phone";// code if session is null
        }









        if (HttpContext.Current.Session["lastname"] != null)
        { lastname.Text = Session["lastname"].ToString();// code if session is not null
        }
        else
        {lastname.Text = "lastname";// code if session is null
        }












        if (HttpContext.Current.Session["location"] != null)
        {address1.Text = Session["location"].ToString(); // code if session is not null
        }
        else
        {address1.Text = "location";// code if session is null
        }











        if (HttpContext.Current.Session["city"] != null)
        {city.Text = Session["city"].ToString();// code if session is not null
        }
        else
        {city.Text = "city";// code if session is null
        }









        if (HttpContext.Current.Session["foodtotal"] != null)
        {sub = Session["foodtotal"].ToString();// code if session is not null
        }
        else
        {sub = "foodtotal";// code if session is null
        }
          






            if (HttpContext.Current.Session["w"] != null)
            {sub1 = Session["w"].ToString();// code if session is not null
            }
            else
            {sub1 = "0";// code if session is null
            }
           


            guid = Request.QueryString["s"];







            if (HttpContext.Current.Session["firstname"] != null)
            {lbname.Text = Session["firstname"].ToString();// code if session is not null
            }
            else
            {lbname.Text = "firstname";// code if session is null
            }
            

            Session["q"] = Convert.ToInt32(sub) + Convert.ToInt32(sub1);




            if (HttpContext.Current.Session["q"] != null)
            {Label3.Text = Session["q"].ToString();// code if session is not null
            }
            else
            {Label3.Text = "q";// code if session is null
            }
        










            //amount.Enabled = false;
            //service_provider.Enabled = false;
            if (!IsPostBack)
            {
                amount.Text = Label3.Text;
            }
            id();
            try
            {
                key.Value = ConfigurationManager.AppSettings["MERCHANT_KEY"];

                if (!IsPostBack)
                {
                    frmError.Visible = false; // error form
                }
                else
                {
                    //frmError.Visible = true;
                }
                if (string.IsNullOrEmpty(Request.Form["hash"]))
                {
                    submit.Visible = true;
                }
                else
                {
                    submit.Visible = false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<span style='color:red'>" + ex.Message + "</span>");

            }
       
    }



    public string Generatehash512(string text)
    {

        byte[] message = Encoding.UTF8.GetBytes(text);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;

    }

    private void id()
    {

        try
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand c = new SqlCommand("select d from temp where id='" + guid + "' order by d desc", con);
            SqlDataReader dr2 = c.ExecuteReader();
            if (dr2.Read())
            {

                int max = Convert.ToInt32(dr2[0].ToString());
                dr2.Close();

                SqlCommand c1 = new SqlCommand("select d from temp where id='" + guid + "' order by d asc", con);
                SqlDataReader dr3 = c1.ExecuteReader();
                if (dr3.Read())
                {

                    int min = Convert.ToInt32(dr3[0].ToString());
                    dr3.Close();

                    for (int i1 = min; i1 <= max; i1++)
                    {



                        SqlCommand cmd = new SqlCommand("select * from temp where id='" + guid + "' AND d='" + i1 + "'", con);
                        SqlDataReader dr4 = cmd.ExecuteReader();
                        if (dr4.Read())
                        {
                            //string id = i1.ToString();
                            //string sub1 = dr4["totalitems"].ToString();
                            //string sub2 = dr4["itemname"].ToString();
                            //string sub3 = dr4["price"].ToString();
                            //string sub4 = dr4["totalrupee"].ToString();
                            //string sub5 = dr4["subtotal"].ToString();
                            //dr4.Close();
                            //SqlCommand cm = new SqlCommand("select * from temp where id ='" + i1 + "'", con);
                            //SqlDataReader d = cm.ExecuteReader();
                            //if (d.Read())
                            //{


                            // string city = dr3[9].ToString();


                            Panel p1 = new Panel();
                            p1.ID = "panel" + i1.ToString();
                            p1.Attributes.Add("style", " width:395px;  height:auto; float:left; margin:10px;");
                            PlaceHolder1.Controls.Add(p1);

                            Label l = new Label();
                            l.ID = "l" + i1.ToString();
                            l.Text = dr4["totalitems"].ToString();
                            l.Attributes.Add("style", "float:left");
                            l.Font.Size = 12;
                            l.Width = 20;
                            p1.Controls.Add(l);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            Label l1 = new Label();
                            l1.ID = "l1" + i1.ToString();
                            l1.Text = dr4["itemname"].ToString();
                            l1.Attributes.Add("style", "width:300px; float:left; margin-left: 10px;");
                            l1.Font.Size = 12;
                            p1.Controls.Add(l1);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            //Label l2 = new Label();
                            //l2.ID = "l2" + i1.ToString();
                            //l2.Text = dr4["price"].ToString();
                            //l2.Font.Size = 12;
                            //p1.Controls.Add(l2);
                            //p1.Controls.Add(new LiteralControl("&nbsp"));

                            //Label l3 = new Label();
                            //l3.ID = "l3" + i1.ToString();
                            //l3.Text = dr4["totalrupee"].ToString();
                            //l3.Font.Size = 12;
                            //p1.Controls.Add(l3);
                            //p1.Controls.Add(new LiteralControl("&nbsp"));

                            Label l4 = new Label();
                            l4.ID = "l4" + i1.ToString();
                            l4.Text = dr4["totalrupee"].ToString();
                            l4.Attributes.Add("style", "float:left");
                            l4.Font.Size = 12;
                            p1.Controls.Add(l4);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            //Panel p2 = new Panel();
                            //p2.ID = "panel" + i1.ToString();
                            //p2.Attributes.Add("style", " width:395px;  height:auto; float:left; margin:10px;");
                            //PlaceHolder2.Controls.Add(p2);

                            //  Label l5 = new Label();
                            //  l5.ID = "l5" + i1.ToString();
                            //  l5.Text = dr4["subtotal"].ToString(); ;
                            ////l5.Attributes.Add("style", "font-size:");
                            //  l5.Font.Size = 15;
                            //  p1.Controls.Add(l5);
                            //  p1.Controls.Add(new LiteralControl("&nbsp"));

                            //HyperLink hyper = new HyperLink();
                            //hyper.Text = "" + d["sub_category"].ToString();
                            //// hyper.Width = 450;
                            //hyper.Font.Size = 12;
                            //hyper.NavigateUrl = (string.Format("~/subcate.aspx?subcate=" + sub + ""));
                            //p1.Controls.Add(hyper);
                            //p1.Controls.Add(new LiteralControl("<br/>"));

                            dr4.Close();
                            PlaceHolder1.Controls.Add(new LiteralControl());
                        }





                        else
                        {
                            dr4.Close();
                        }
                    }


                }
                else
                {
                    dr2.Close();
                }
                con.Close();
            }
        }
        catch (Exception e1)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/Default.aspx");
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        try
        { 

        string[] hashVarsSeq;
        string hash_string = string.Empty;


        if (string.IsNullOrEmpty(Request.Form["txnid"])) // generating txnid
        {
            Random rnd = new Random();
            string strHash = Generatehash512(rnd.ToString() + DateTime.Now);
            txnid1 = strHash.ToString().Substring(0, 20);
            
        }
        else
        {
            txnid1 = Request.Form["txnid"];
        }
        if (string.IsNullOrEmpty(Request.Form["hash"])) // generating hash value
        {
            if (
                string.IsNullOrEmpty(ConfigurationManager.AppSettings["MERCHANT_KEY"]) ||
                string.IsNullOrEmpty(txnid1) ||
                string.IsNullOrEmpty(Request.Form["amount"]) ||
                string.IsNullOrEmpty(Request.Form["firstname"]) ||
                string.IsNullOrEmpty(Request.Form["email"]) ||
                string.IsNullOrEmpty(Request.Form["phone"]) ||
                string.IsNullOrEmpty(Request.Form["productinfo"]) ||
                string.IsNullOrEmpty(Request.Form["surl"]) ||
                string.IsNullOrEmpty(Request.Form["furl"]) ||
				string.IsNullOrEmpty(Request.Form["service_provider"]) 
                )
            {
                //error

                frmError.Visible = true;
                return;
            }

            else
            {
                frmError.Visible = false;
                hashVarsSeq = ConfigurationManager.AppSettings["hashSequence"].Split('|'); // spliting hash sequence from config
                hash_string = "";
                foreach (string hash_var in hashVarsSeq)
                {
                    if (hash_var == "key")
                    {
                        hash_string = hash_string + ConfigurationManager.AppSettings["MERCHANT_KEY"];
                        hash_string = hash_string + '|';
                    }
                    else if (hash_var == "txnid")
                    {
                        hash_string = hash_string + txnid1;
                        hash_string = hash_string + '|';
                    }
                    else if (hash_var == "amount")
                    {
                        hash_string = hash_string + Convert.ToDecimal(Request.Form[hash_var]).ToString("g29");
                        hash_string = hash_string + '|';
                    }
                    else
                    {

                        hash_string = hash_string + (Request.Form[hash_var] != null ? Request.Form[hash_var] : "");// isset if else
                        hash_string = hash_string + '|';
                    }
                }

                hash_string += ConfigurationManager.AppSettings["SALT"];// appending SALT

                hash1 = Generatehash512(hash_string).ToLower();         //generating hash
                action1 = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment";// setting URL

            }


        }

        else if (!string.IsNullOrEmpty(Request.Form["hash"]))
        {
            hash1 = Request.Form["hash"];
            action1 = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment";

        }

      


        if (!string.IsNullOrEmpty(hash1))
        {
            hash.Value = hash1; 
            txnid.Value = txnid1;

            System.Collections.Hashtable data = new System.Collections.Hashtable(); // adding values in gash table for data post
            data.Add("hash", hash.Value);
            data.Add("txnid", txnid.Value);
            data.Add("key", key.Value);
            string AmountForm = Convert.ToDecimal(amount.Text.Trim()).ToString("g29");// eliminating trailing zeros
            amount.Text = AmountForm;
            data.Add("amount", AmountForm);
            data.Add("firstname", firstname.Text.Trim());
            data.Add("email", email.Text.Trim());
            data.Add("enforce_paymethod", "DC");
            data.Add("phone", phone.Text.Trim());
            data.Add("productinfo", productinfo.Text.Trim());
            data.Add("surl", surl.Text.Trim());
            data.Add("furl", furl.Text.Trim());
            data.Add("lastname", lastname.Text.Trim());
            data.Add("curl", curl.Text.Trim());
            data.Add("address1", address1.Text.Trim());
            data.Add("address2", address2.Text.Trim());
            data.Add("city", city.Text.Trim());
            data.Add("state", state.Text.Trim());
            data.Add("country", country.Text.Trim());
            data.Add("zipcode", zipcode.Text.Trim());
            data.Add("udf1", udf1.Text.Trim());
            data.Add("udf2", udf2.Text.Trim());
            data.Add("udf3", udf3.Text.Trim());
            data.Add("udf4", udf4.Text.Trim());
            data.Add("udf5", udf5.Text.Trim());
            data.Add("pg", pg.Text.Trim());
            data.Add("service_provider", service_provider.Text.Trim());


            string strForm = PreparePOSTForm(action1, data);
            Page.Controls.Add(new LiteralControl(strForm));

        }

        else
        {
            //no hash
        
        }

    }

    catch (Exception ex)

    {
        Response.Write("<span style='color:red'>" + ex.Message + "</span>");
    
    }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand c = new SqlCommand("select d from temp where id='"+guid+"' order by d desc", con);
        SqlDataReader dr2 = c.ExecuteReader();
        if (dr2.Read())
        {

            int max = Convert.ToInt32(dr2[0].ToString());
            dr2.Close();

            SqlCommand c1 = new SqlCommand("select d from temp where id='" + guid + "' order by d asc", con);
            SqlDataReader dr3 = c.ExecuteReader();
            if (dr3.Read())
            {

                int min = Convert.ToInt32(dr3[0].ToString());
                dr3.Close();

                for (int i1 = min; i1 <= max; i1++)
                {
                    SqlConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                    connn.Open();
                    SqlCommand cc = new SqlCommand("select itemname from temp where id='" + guid + "'", connn);
                    SqlDataReader drr = cc.ExecuteReader();
                    if (drr.Read())
                    {
                        string iname = drr["itemname"].ToString();
                        drr.Close();

                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into food_order values(@order_id, @fstname, @email, @itemname, @companyname, @price, @veg, @day)", conn);
                        cmd.Parameters.AddWithValue("@order_id", guid);
                        cmd.Parameters.AddWithValue("@fstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@itemname", iname);
                        cmd.Parameters.AddWithValue("@companyname", "ss");
                        cmd.Parameters.AddWithValue("@price", Label3.Text);
                        cmd.Parameters.AddWithValue("@veg", "Veg");
                        cmd.Parameters.AddWithValue("@day", Session["dayofweek"]);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        drr.Close();
                    }
                    connn.Close();
                }
            }

            //deletefunction();
        }
        con.Close();
    }



    public void deletefunction()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand cmddelete = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
            cmddelete.ExecuteNonQuery();

            SqlCommand cmdtemp = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
            cmdtemp.ExecuteNonQuery();
        }
        catch (Exception e2)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/Default.aspx");
        }
    }

    private string PreparePOSTForm(string url, System.Collections.Hashtable data)      // post form
    {
        //Set a name for the form
        string formID = "PostForm";
        //Build the form using the specified data to be posted.
        StringBuilder strForm = new StringBuilder();
        strForm.Append("<form id=\"" + formID + "\" name=\"" +
                       formID + "\" action=\"" + url +
                       "\" method=\"POST\">");

        foreach (System.Collections.DictionaryEntry key in data)
        {

            strForm.Append("<input type=\"hidden\" name=\"" + key.Key +
                           "\" value=\"" + key.Value + "\">");
        }


        strForm.Append("</form>");
        //Build the JavaScript which will do the Posting operation.
        StringBuilder strScript = new StringBuilder();
        strScript.Append("<script language='javascript'>");
        strScript.Append("var v" + formID + " = document." +
                         formID + ";");
        strScript.Append("v" + formID + ".submit();");
        strScript.Append("</script>");
        //Return the form and the script concatenated.
        //(The order is important, Form then JavaScript)
        return strForm.ToString() + strScript.ToString();
    }

    

   
    
}
