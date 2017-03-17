using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Panel29.Visible = false;
        //Panel30.Visible = false;
        //Panel31.Visible = false;
        //Panel32.Visible = false;
        //Panel33.Visible = false;
        //Panel34.Visible = false;
        //Panel35.Visible = false;
        //Panel36.Visible = false;
        //Panel37.Visible = false;
        //Panel38.Visible = false;
        //Panel39.Visible = false;
        //Panel40.Visible = false;
        //Panel41.Visible = false;
        //Panel42.Visible = false;
        //Panel43.Visible = false;
        //Panel44.Visible = false;
        //Panel45.Visible = false;
        //Panel46.Visible = false;
        //Panel47.Visible = false;
        //Panel48.Visible = false;
        //Panel49.Visible = false;
        //Panel50.Visible = false;

        Label1.Text = "Ankit";

        if (lbsubtotal.Text == "0.00")
        {
            Button1.Enabled = false;

        }
        else if (lbsubtotal.Text == "0.0")
        {
            Button1.Enabled = false;

        }
        else if (lbsubtotal.Text == "0")
        {
            Button1.Enabled = false;

        }

        TextBox1.AutoPostBack = true;
        TextBox2.AutoPostBack = true;
        TextBox3.AutoPostBack = true;
        TextBox4.AutoPostBack = true;
        TextBox5.AutoPostBack = true;
        TextBox6.AutoPostBack = true;
        TextBox7.AutoPostBack = true;
        TextBox8.AutoPostBack = true;
        TextBox9.AutoPostBack = true;
        TextBox10.AutoPostBack = true;
        TextBox11.AutoPostBack = true;
        TextBox12.AutoPostBack = true;
        TextBox13.AutoPostBack = true;
        TextBox14.AutoPostBack = true;
        TextBox15.AutoPostBack = true;
        TextBox16.AutoPostBack = true;
        TextBox17.AutoPostBack = true;
        TextBox18.AutoPostBack = true;
        TextBox19.AutoPostBack = true;
        TextBox20.AutoPostBack = true;
        TextBox21.AutoPostBack = true;
        TextBox22.AutoPostBack = true;
        if (!IsPostBack)
        {

            getdata1();
            imgshow1();
            imgshow2();
            imgshow3();
           // imgshow4();
           // imgshow5();
        //   imgshow6();
         // imgshow7();
        //    imgshow8();
        //    imgshow9();
        //    imgshow10();
        //    imgshow11();
        //    imgshow12();
        //    imgshow13();
        //    imgshow14();
        //    imgshow15();
        //    imgshow16();
        //    imgshow17();
        //    imgshow18();
        //    imgshow19();
        //    imgshow20();
        //    imgshow21();
        //    imgshow22();
        }
    }

    private void getdata1()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();

        SqlCommand cmd = new SqlCommand("Select * from location where fstname='" + Label1.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            txtmetname.Text = "My Lunch Meeting";
            txtloc.Text = dr[4].ToString();

            txtcont.Text = dr[0].ToString();

        }

        con.Close();

        SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con1.Open();
        SqlCommand cmd1 = new SqlCommand("Select * from login where fstname='" + Label1.Text + "'", con1);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        if (dr1.Read())
        {

            txtph.Text = dr1["phone"].ToString();
        }
        con1.Close();

        if (lbmndy.Text == "Monday" & DateTime.Now.DayOfWeek.ToString() == "Monday")
        {
            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel1.BackColor = System.Drawing.Color.Red;
            Panel1.ForeColor = System.Drawing.Color.White;

        }

        else
        { lbmndydate.Enabled = false; }

        if (lbtsdy.Text == "Tuesday" & DateTime.Now.DayOfWeek.ToString() == "Tuesday")
        {
            lbtsdydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel2.BackColor = System.Drawing.Color.Red;
            Panel2.ForeColor = System.Drawing.Color.White;

        }

        //else
        //{ lbmndydate.Enabled = false; }

        if (lbwndy.Text == "Wednesday" & DateTime.Now.DayOfWeek.ToString() == "Wednesday")
        {
            lbwndydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel3.BackColor = System.Drawing.Color.Red;
            Panel3.ForeColor = System.Drawing.Color.White;
        }
        if (lbthdy.Text == "Thursday" & DateTime.Now.DayOfWeek.ToString() == "Thursday")
        {
            lbthdydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel4.BackColor = System.Drawing.Color.Red;
            Panel4.ForeColor = System.Drawing.Color.White;
        }
        if (lbfdy.Text == "Friday" & DateTime.Now.DayOfWeek.ToString() == "Friday")
        {
            lbfdydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel5.BackColor = System.Drawing.Color.Red;
            Panel5.ForeColor = System.Drawing.Color.White;

        }
        if (lbstdy.Text == "Saturday" & DateTime.Now.DayOfWeek.ToString() == "Saturday")
        {
            lbstdydate.Text = System.DateTime.Now.ToString("MMMM dd");
            Panel6.BackColor = System.Drawing.Color.Red;
            Panel6.ForeColor = System.Drawing.Color.White;
        }




        lblmenu.Text = DateTime.Now.DayOfWeek.ToString();
    }

    //protected void txtname_TextChanged(object sender, EventArgs e)
    //{
    //    lblcount.Text = "Show me ";

    //}

    //public void getdata()
    //{
    //    SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    //    con4.Open();
    //    SqlCommand cmd4 = new SqlCommand("select img_id from food_display order by img_id desc", con4);
    //    SqlDataReader dr4 = cmd4.ExecuteReader();
    //    if (dr4.Read())
    //    {
    //        int a = Convert.ToInt32(dr4[0].ToString());

    //        dr4.Close();
    //        for (int i = a; i >= 1; i--)
    //        {
    //            SqlDataAdapter da = new SqlDataAdapter("select * from food_display where img_id ='" + i + "'", con4);
    //            string bookid = i.ToString();


    //            Panel p = new Panel();
    //            p.ID = "panel" + i.ToString();
    //            p.Attributes.Add("style", " width:700px;  height:160px; float:left; margin-left:10px;");
    //            PlaceHolder1.Controls.Add(p);

    //            TextBox txtName = new TextBox();
    //            txtName.ID = "textbox" + i.ToString();
    //            txtName.Attributes.Add("style", " width:60px;  height:60px; float:left; margin-left:-127px; margin-top:-150px;");
    //            txtName.Text = "0";
    //            txtName.AutoPostBack = true;
    //            lblcount.Text = txtName.Text;

    //            txtName.TextChanged += new System.EventHandler(txtname_TextChanged);
    //            PlaceHolder1.Controls.Add(txtName);



    //            //int d;
    //            //int.TryParse(txtName.Text, out d);

    //            //lblcount.Text = (d+d).ToString();

    //            HyperLink hll = new HyperLink();

    //            hll.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", bookid));

    //            hll.NavigateUrl = (string.Format("~/by_movie_marque.aspx?bookid={0}", bookid));

    //            p.Controls.Add(hll);

    //            DetailsView dv = new DetailsView();
    //            dv.ID = "dv" + i.ToString();
    //            dv.AutoGenerateRows = false;
    //            dv.Style.Add("border-color", "White");
    //            dv.Style.Add("margin-top", "10px");
    //            p.Controls.Add(dv);

    //            HyperLinkField hlf = new HyperLinkField();
    //            hlf.HeaderText = "";
    //            hlf.DataTextField = "itemname";
    //            hlf.ItemStyle.Font.Size = FontUnit.Point(15);

    //            hlf.NavigateUrl = (string.Format("~/Default.aspx?bookid={0}", bookid));
    //            dv.Fields.Add(hlf);





    //            BoundField bf2 = new BoundField();
    //            bf2.ItemStyle.Font.Size = FontUnit.Point(12);
    //            bf2.HeaderText = "";
    //            bf2.DataField = "companyname";
    //            dv.Fields.Add(bf2);

    //            BoundField bf5 = new BoundField();

    //            //bf5.HeaderText = "Rs.";
    //            bf5.DataField = "price";
    //            bf5.ItemStyle.Height = Unit.Pixel(135);

    //            dv.Fields.Add(bf5);



    //            BoundField bf3 = new BoundField();
    //            dv.Fields.Add(bf3);
    //            BoundField bf4 = new BoundField();
    //            dv.Fields.Add(bf4);

    //            DataSet ds = new DataSet();
    //            da.Fill(ds);
    //            dv.DataSource = ds.Tables[0];
    //            dv.DataBind();



    //            PlaceHolder1.Controls.Add(new LiteralControl("&nbsp"));
    //        }
    //    }
    //}

    private void imgshow1()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='1'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image1.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll1.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname1.Text = dr["itemname"].ToString();
            lbcompany1.Text = dr["companyname"].ToString();
            lbprice1.Text = dr["price"].ToString();
        }
        else
        {
            Panel7.Visible = false;
        }
    }
    private void imgshow2()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='2'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image2.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll2.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname2.Text = dr["itemname"].ToString();
            lbcompany2.Text = dr["companyname"].ToString();
            lbprice2.Text = dr["price"].ToString();
        }
        else
        {
            Panel8.Visible = false;
        }
    }
    private void imgshow3()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='3'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image3.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll3.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname3.Text = dr["itemname"].ToString();
            lbcompany3.Text = dr["companyname"].ToString();
            lbprice3.Text = dr["price"].ToString();
        }
        else
        {
            Panel9.Visible = false;
        }
    }
    private void imgshow4()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='4'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image4.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll4.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname4.Text = dr["itemname"].ToString();
            lbcompany4.Text = dr["companyname"].ToString();
            lbprice4.Text = dr["price"].ToString();
        }
        else
        {
            Panel10.Visible = false;
        }
    }
    private void imgshow5()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='5'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image5.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll5.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname5.Text = dr["itemname"].ToString();
            lbcompany5.Text = dr["companyname"].ToString();
            lbprice5.Text = dr["price"].ToString();
        }
        else
        {
            Panel11.Visible = false;
        }
    }
    private void imgshow6()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='6'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image6.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll6.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname6.Text = dr["itemname"].ToString();
            lbcompany6.Text = dr["companyname"].ToString();
            lbprice6.Text = dr["price"].ToString();
        }
        else
        {
            Panel12.Visible = false;
        }
    }
    private void imgshow7()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='7'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image7.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll7.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname7.Text = dr["itemname"].ToString();
            lbcompany7.Text = dr["companyname"].ToString();
            lbprice7.Text = dr["price"].ToString();
        }
        else
        {
            Panel13.Visible = false;
        }
    }
    private void imgshow8()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='8'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image8.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll8.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname8.Text = dr["itemname"].ToString();
            lbcompany8.Text = dr["companyname"].ToString();
            lbprice8.Text = dr["price"].ToString();
        }
        else
        {
            Panel14.Visible = false;
        }
    }
    private void imgshow9()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='9'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image9.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll9.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname9.Text = dr["itemname"].ToString();
            lbcompany9.Text = dr["companyname"].ToString();
            lbprice9.Text = dr["price"].ToString();
        }
        else
        {
            Panel15.Visible = false;
        }
    }
    private void imgshow10()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='10'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image10.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll10.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname10.Text = dr["itemname"].ToString();
            lbcompany10.Text = dr["companyname"].ToString();
            lbprice10.Text = dr["price"].ToString();
        }
        else
        {
            Panel16.Visible = false;
        }
    }
    private void imgshow11()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='11'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image11.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll11.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname11.Text = dr["itemname"].ToString();
            lbcompany11.Text = dr["companyname"].ToString();
            lbprice11.Text = dr["price"].ToString();
        }
        else
        {
            Panel17.Visible = false;
        }
    }
    private void imgshow12()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='12'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image12.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll12.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname12.Text = dr["itemname"].ToString();
            lbcompany12.Text = dr["companyname"].ToString();
            lbprice12.Text = dr["price"].ToString();
        }
        else
        {
            Panel18.Visible = false;
        }
    }
    private void imgshow13()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='13'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image13.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll13.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname13.Text = dr["itemname"].ToString();
            lbcompany13.Text = dr["companyname"].ToString();
            lbprice13.Text = dr["price"].ToString();
        }
        else
        {
            Panel19.Visible = false;
        }
    }
    private void imgshow14()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='14'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image14.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll14.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname14.Text = dr["itemname"].ToString();
            lbcompany14.Text = dr["companyname"].ToString();
            lbprice14.Text = dr["price"].ToString();
        }
        else
        {
            Panel20.Visible = false;
        }
    }
    private void imgshow15()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='15'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image15.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll15.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname15.Text = dr["itemname"].ToString();
            lbcompany15.Text = dr["companyname"].ToString();
            lbprice15.Text = dr["price"].ToString();
        }
        else
        {
            Panel21.Visible = false;
        }
    }
    private void imgshow16()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='16'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image16.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll16.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname16.Text = dr["itemname"].ToString();
            lbcompany16.Text = dr["companyname"].ToString();
            lbprice16.Text = dr["price"].ToString();
        }
        else
        {
            Panel22.Visible = false;
        }
    }
    private void imgshow17()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='17'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image17.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll17.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname17.Text = dr["itemname"].ToString();
            lbcompany17.Text = dr["companyname"].ToString();
            lbprice17.Text = dr["price"].ToString();
        }
        else
        {
            Panel23.Visible = false;
        }
    }
    private void imgshow18()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='18'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image18.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll18.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname18.Text = dr["itemname"].ToString();
            lbcompany18.Text = dr["companyname"].ToString();
            lbprice18.Text = dr["price"].ToString();
        }
        else
        {
            Panel24.Visible = false;
        }
    }
    private void imgshow19()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='19'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image19.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll19.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname19.Text = dr["itemname"].ToString();
            lbcompany19.Text = dr["companyname"].ToString();
            lbprice19.Text = dr["price"].ToString();
        }
        else
        {
            Panel25.Visible = false;
        }
    }
    private void imgshow20()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='20'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image20.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll20.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname20.Text = dr["itemname"].ToString();
            lbcompany20.Text = dr["companyname"].ToString();
            lbprice20.Text = dr["price"].ToString();
        }
        else
        {
            Panel26.Visible = false;
        }
    }
    private void imgshow21()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='21'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image21.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll21.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname21.Text = dr["itemname"].ToString();
            lbcompany21.Text = dr["companyname"].ToString();
            lbprice21.Text = dr["price"].ToString();
        }
        else
        {
            Panel27.Visible = false;
        }
    }
    private void imgshow22()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' and img_id='22'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string img = dr[0].ToString();
            Image22.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", img));
            hll22.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", img));
            lbitemname22.Text = dr["itemname"].ToString();
            lbcompany22.Text = dr["companyname"].ToString();
            lbprice22.Text = dr["price"].ToString();
        }
        else
        {
            Panel28.Visible = false;
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);
        // int.TryParse(lbsubtotal.Text, out sub);
        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
             a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
             a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        lbquantity1.Visible = true;
        lbitem1.Visible = true;
        lbrate1.Visible = true;
        // lbinr1.Visible = true;
        lbinrr1.Visible = true;
        lblat1.Visible = true;
        lbleach1.Visible = true;
        lblx1.Visible = true;
        lbrateonly1.Visible = true;

        //Panel29.Visible = true;

        lbquantity1.Text = TextBox1.Text;
        lbitem1.Text = lbitemname1.Text;
        lbrate1.Text = lbprice1.Text;
        lbrateonly1.Text = lbprice1.Text;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);
        //int.TryParse(lbsubtotal.Text, out sub);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
              a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
              a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        // lbquantity2.Visible = true;
        // lbitem2.Visible = true;
        // lbrate2.Visible = true;
        // lbinr2.Visible = true;
        // lblat2.Visible = true;
        // lbleach2.Visible = true;
        // lblx2.Visible = true;
        // lbinrr2.Visible = true;
        // lbrateonly2.Visible = true;
        Panel30.Visible = true;

        lbquantity2.Text = TextBox2.Text;
        lbitem2.Text = lbitemname2.Text;
        lbrate2.Text = lbprice2.Text;
        lbrateonly2.Text = lbprice2.Text;

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        lbquantity3.Visible = true;
        lbitem3.Visible = true;
        lbrate3.Visible = true;
        lbinr3.Visible = true;
        lbinrr3.Visible = true;
        lblat3.Visible = true;
        lbleach3.Visible = true;
        lblx3.Visible = true;
        lbrateonly3.Visible = true;

        //Panel31.Visible = true;

        lbquantity3.Text = TextBox3.Text;
        lbitem3.Text = lbitemname3.Text;
        lbrate3.Text = lbprice3.Text;
        lbrateonly3.Text = lbprice3.Text;

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity4.Visible = true;
        //lbitem4.Visible = true;
        //lbrate4.Visible = true;
        //lbinr4.Visible = true;
        //lbinrr4.Visible = true;
        //lblat4.Visible = true;
        //lbleach4.Visible = true;
        //lblx4.Visible = true;
        //lbrateonly4.Visible = true;

        Panel32.Visible = true;

        lbquantity4.Text = TextBox4.Text;
        lbitem4.Text = lbitemname4.Text;
        lbrate4.Text = lbprice4.Text;
        lbrateonly4.Text = lbprice4.Text;

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity5.Visible = true;
        //lbitem5.Visible = true;
        //lbrate5.Visible = true;
        //lbinr5.Visible = true;
        //lbinrr5.Visible = true;
        //lblat5.Visible = true;
        //lbleach5.Visible = true;
        //lblx5.Visible = true;
        //lbrateonly5.Visible = true;

        Panel33.Visible = true;

        lbquantity5.Text = TextBox5.Text;
        lbitem5.Text = lbitemname5.Text;
        lbrate5.Text = lbprice5.Text;
        lbrateonly5.Text = lbprice5.Text;

    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity6.Visible = true;
        //lbitem6.Visible = true;
        //lbrate6.Visible = true;
        //lbinr6.Visible = true;
        //lbinrr6.Visible = true;
        //lblat6.Visible = true;
        //lbleach6.Visible = true;
        //lblx6.Visible = true;
        //lbrateonly6.Visible = true;

        Panel34.Visible = true;

        lbquantity6.Text = TextBox6.Text;
        lbitem6.Text = lbitemname6.Text;
        lbrate6.Text = lbprice6.Text;
        lbrateonly6.Text = lbprice6.Text;

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity7.Visible = true;
        //lbitem7.Visible = true;
        //lbrate7.Visible = true;
        //lbinr7.Visible = true;
        //lbinrr7.Visible = true;
        //lblat7.Visible = true;
        //lbleach7.Visible = true;
        //lblx7.Visible = true;
        //lbrateonly7.Visible = true;

        Panel35.Visible = true;

        lbquantity7.Text = TextBox7.Text;
        lbitem7.Text = lbitemname7.Text;
        lbrate7.Text = lbprice7.Text;
        lbrateonly7.Text = lbprice7.Text;

    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity8.Visible = true;
        //lbitem8.Visible = true;
        //lbrate8.Visible = true;
        //lbinr8.Visible = true;
        //lbinrr8.Visible = true;
        //lblat8.Visible = true;
        //lbleach8.Visible = true;
        //lblx8.Visible = true;
        //lbrateonly8.Visible = true;

        Panel36.Visible = true;

        lbquantity8.Text = TextBox8.Text;
        lbitem8.Text = lbitemname8.Text;
        lbrate8.Text = lbprice8.Text;
        lbrateonly8.Text = lbprice8.Text;
    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity9.Visible = true;
        //lbitem9.Visible = true;
        //lbrate9.Visible = true;
        //lbinr9.Visible = true;
        //lbinrr9.Visible = true;
        //lblat9.Visible = true;
        //lbleach9.Visible = true;
        //lblx9.Visible = true;
        //lbrateonly9.Visible = true;

        Panel37.Visible = true;

        lbquantity9.Text = TextBox9.Text;
        lbitem9.Text = lbitemname9.Text;
        lbrate9.Text = lbprice9.Text;
        lbrateonly9.Text = lbprice9.Text;

    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        //lbquantity10.Visible = true;
        //lbitem10.Visible = true;
        //lbrate10.Visible = true;
        //lbinr10.Visible = true;
        //lbinrr10.Visible = true;
        //lbrateonly10.Visible = true;

        Panel38.Visible = true;

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();
        lbquantity10.Text = TextBox10.Text;
        lbitem10.Text = lbitemname10.Text;
        lbrate10.Text = lbprice10.Text;
        lbrateonly10.Text = lbprice10.Text;
    }
    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity11.Visible = true;
        //lbitem11.Visible = true;
        //lbrate11.Visible = true;
        //lbinr11.Visible = true;
        //lbinrr11.Visible = true;
        //lbrateonly11.Visible = true;

        Panel39.Visible = true;

        lbquantity11.Text = TextBox11.Text;
        lbitem11.Text = lbitemname11.Text;
        lbrate11.Text = lbprice11.Text;
        lbrateonly11.Text = lbprice11.Text;

    }
    protected void TextBox12_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity12.Visible = true;
        //lbitem12.Visible = true;
        //lbrate12.Visible = true;
        //lbinr12.Visible = true;
        //lbinrr12.Visible = true;
        //lbrateonly12.Visible = true;

        Panel40.Visible = true;

        lbquantity12.Text = TextBox12.Text;
        lbitem12.Text = lbitemname12.Text;
        lbrate12.Text = lbprice12.Text;
        lbrateonly12.Text = lbprice12.Text;
    }
    protected void TextBox13_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
            a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
            a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity16.Visible = true;
        //lbitem16.Visible = true;
        //lbrate16.Visible = true;
        //lbinr16.Visible = true;
        //lbinrr16.Visible = true;
        //lbrateonly16.Visible = true;

        Panel41.Visible = true;

        lbquantity13.Text = TextBox13.Text;
        lbitem13.Text = lbitemname13.Text;
        lbrate13.Text = lbprice13.Text;
        lbrateonly13.Text = lbprice13.Text;
    }
    protected void TextBox14_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity14.Visible = true;
        //lbitem14.Visible = true;
        //lbrate14.Visible = true;
        //lbinr14.Visible = true;
        //lbinrr14.Visible = true;
        //lbrateonly14.Visible = true;

        Panel42.Visible = true;

        lbquantity14.Text = TextBox14.Text;
        lbitem14.Text = lbitemname14.Text;
        lbrate14.Text = lbprice14.Text;
        lbrateonly14.Text = lbprice14.Text;
    }
    protected void TextBox15_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity15.Visible = true;
        //lbitem15.Visible = true;
        //lbrate15.Visible = true;
        //lbinr15.Visible = true;
        //lbinrr15.Visible = true;
        //lbrateonly15.Visible = true;

        Panel43.Visible = true;

        lbquantity15.Text = TextBox15.Text;
        lbitem15.Text = lbitemname15.Text;
        lbrate15.Text = lbprice15.Text;
        lbrateonly15.Text = lbprice15.Text;
    }
    protected void TextBox16_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity16.Visible = true;
        //lbitem16.Visible = true;
        //lbrate16.Visible = true;
        //lbinr16.Visible = true;
        //lbinrr16.Visible = true;
        //lbrateonly16.Visible = true;

        Panel44.Visible = true;

        lbquantity16.Text = TextBox16.Text;
        lbitem16.Text = lbitemname16.Text;
        lbrate16.Text = lbprice16.Text;
        lbrateonly16.Text = lbprice16.Text;

    }
    protected void TextBox17_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity17.Visible = true;
        //lbitem17.Visible = true;
        //lbrate17.Visible = true;
        //lbinr17.Visible = true;
        //lbinrr17.Visible = true;
        //lbrateonly17.Visible = true;

        Panel45.Visible = true;

        lbquantity17.Text = TextBox17.Text;
        lbitem17.Text = lbitemname17.Text;
        lbrate17.Text = lbprice17.Text;
        lbrateonly17.Text = lbprice17.Text;

    }
    protected void TextBox18_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity18.Visible = true;
        //lbitem18.Visible = true;
        //lbrate18.Visible = true;
        //lbinr18.Visible = true;
        //lbinrr18.Visible = true;
        //lbrateonly18.Visible = true;

        Panel46.Visible = true;

        lbquantity18.Text = TextBox18.Text;
        lbitem18.Text = lbitemname18.Text;
        lbrate18.Text = lbprice18.Text;
        lbrateonly18.Text = lbprice18.Text;

    }
    protected void TextBox19_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity19.Visible = true;
        //lbitem19.Visible = true;
        //lbrate19.Visible = true;
        //lbinr19.Visible = true;
        //lbinrr19.Visible = true;
        //lbrateonly19.Visible = true;
        Panel47.Visible = true;
        lbquantity19.Text = TextBox19.Text;
        lbitem19.Text = lbitemname19.Text;
        lbrate19.Text = lbprice19.Text;
        lbrateonly19.Text = lbprice19.Text;
    }
    protected void TextBox20_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity20.Visible = true;
        //lbitem20.Visible = true;
        //lbrate20.Visible = true;
        //lbinr20.Visible = true;
        //lbinrr20.Visible = true;
        //lbrateonly20.Visible = true;
        Panel48.Visible = true;
        lbquantity20.Text = TextBox20.Text;
        lbitem20.Text = lbitemname20.Text;
        lbrate20.Text = lbprice20.Text;
        lbrateonly20.Text = lbprice20.Text;

    }
    protected void TextBox21_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity21.Visible = true;
        //lbitem21.Visible = true;
        //lbrate21.Visible = true;
        //lbinr21.Visible = true;
        //lbinrr21.Visible = true;
        //lbrateonly21.Visible = true;
        Panel49.Visible = true;
        lbquantity21.Text = TextBox21.Text;
        lbitem21.Text = lbitemname21.Text;
        lbrate21.Text = lbprice21.Text;
        lbrateonly21.Text = lbprice21.Text;

    }
    protected void TextBox22_TextChanged(object sender, EventArgs e)
    {
        int a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w;
        int.TryParse(TextBox1.Text, out a);
        int.TryParse(TextBox2.Text, out b);
        int.TryParse(TextBox3.Text, out c);
        int.TryParse(TextBox4.Text, out d);
        int.TryParse(TextBox5.Text, out f);
        int.TryParse(TextBox6.Text, out g);
        int.TryParse(TextBox7.Text, out h);
        int.TryParse(TextBox8.Text, out i);
        int.TryParse(TextBox9.Text, out j);
        int.TryParse(TextBox10.Text, out k);
        int.TryParse(TextBox11.Text, out l);
        int.TryParse(TextBox12.Text, out m);
        int.TryParse(TextBox13.Text, out n);
        int.TryParse(TextBox14.Text, out o);
        int.TryParse(TextBox15.Text, out p);
        int.TryParse(TextBox16.Text, out q);
        int.TryParse(TextBox17.Text, out r);
        int.TryParse(TextBox18.Text, out s);
        int.TryParse(TextBox19.Text, out t);
        int.TryParse(TextBox20.Text, out u);
        int.TryParse(TextBox21.Text, out v);
        int.TryParse(TextBox22.Text, out w);

        lblcount.Text = (a + b + c + d + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w).ToString();

        int a1, b1, c1, d1, f1, g1, h1, i1, j1, k1, l1, m1, n1, o1, p1, q1, r1, s1, t1, u1, v1, w1,
           a2, b2, c2, d2, f2, g2, h2, i2, j2, k2, l2, m2, n2, o2, p2, q2, r2, s2, t2, u2, v2, w2,
           a3, b3, c3, d3, f3, g3, h3, i3, j3, k3, l3, m3, n3, o3, p3, q3, r3, s3, t3, u3, v3, w3;

        int.TryParse(TextBox1.Text, out a1);
        int.TryParse(lbprice1.Text, out a2);

        a3 = Convert.ToInt32((a1 * a2).ToString());

        int.TryParse(TextBox2.Text, out b1);
        int.TryParse(lbprice2.Text, out b2);

        b3 = Convert.ToInt32((b1 * b2).ToString());

        int.TryParse(TextBox3.Text, out c1);
        int.TryParse(lbprice3.Text, out c2);

        c3 = Convert.ToInt32((c1 * c2).ToString());

        int.TryParse(TextBox4.Text, out d1);
        int.TryParse(lbprice4.Text, out d2);

        d3 = Convert.ToInt32((d1 * d2).ToString());

        int.TryParse(TextBox5.Text, out f1);
        int.TryParse(lbprice5.Text, out f2);

        f3 = Convert.ToInt32((f1 * f2).ToString());

        int.TryParse(TextBox6.Text, out g1);
        int.TryParse(lbprice6.Text, out g2);

        g3 = Convert.ToInt32((g1 * g2).ToString());

        int.TryParse(TextBox7.Text, out h1);
        int.TryParse(lbprice7.Text, out h2);

        h3 = Convert.ToInt32((h1 * h2).ToString());

        int.TryParse(TextBox8.Text, out i1);
        int.TryParse(lbprice8.Text, out i2);

        i3 = Convert.ToInt32((i1 * i2).ToString());

        int.TryParse(TextBox9.Text, out j1);
        int.TryParse(lbprice9.Text, out j2);

        j3 = Convert.ToInt32((j1 * j2).ToString());

        int.TryParse(TextBox10.Text, out k1);
        int.TryParse(lbprice10.Text, out k2);

        k3 = Convert.ToInt32((k1 * k2).ToString());

        int.TryParse(TextBox11.Text, out l1);
        int.TryParse(lbprice11.Text, out l2);

        l3 = Convert.ToInt32((l1 * l2).ToString());

        int.TryParse(TextBox12.Text, out m1);
        int.TryParse(lbprice12.Text, out m2);

        m3 = Convert.ToInt32((m1 * m2).ToString());

        int.TryParse(TextBox13.Text, out n1);
        int.TryParse(lbprice13.Text, out n2);

        n3 = Convert.ToInt32((n1 * n2).ToString());

        int.TryParse(TextBox14.Text, out o1);
        int.TryParse(lbprice14.Text, out o2);

        o3 = Convert.ToInt32((o1 * o2).ToString());

        int.TryParse(TextBox15.Text, out p1);
        int.TryParse(lbprice15.Text, out p2);

        p3 = Convert.ToInt32((p1 * p2).ToString());

        int.TryParse(TextBox16.Text, out q1);
        int.TryParse(lbprice16.Text, out q2);

        q3 = Convert.ToInt32((q1 * q2).ToString());

        int.TryParse(TextBox17.Text, out r1);
        int.TryParse(lbprice17.Text, out r2);

        r3 = Convert.ToInt32((r1 * r2).ToString());

        int.TryParse(TextBox18.Text, out s1);
        int.TryParse(lbprice18.Text, out s2);

        s3 = Convert.ToInt32((s1 * s2).ToString());

        int.TryParse(TextBox19.Text, out t1);
        int.TryParse(lbprice19.Text, out t2);

        t3 = Convert.ToInt32((t1 * t2).ToString());

        int.TryParse(TextBox20.Text, out u1);
        int.TryParse(lbprice20.Text, out u2);

        u3 = Convert.ToInt32((u1 * u2).ToString());

        int.TryParse(TextBox21.Text, out v1);
        int.TryParse(lbprice21.Text, out v2);

        v3 = Convert.ToInt32((v1 * v2).ToString());

        int.TryParse(TextBox22.Text, out w1);
        int.TryParse(lbprice22.Text, out w2);

        w3 = Convert.ToInt32((w1 * w2).ToString());

        lbsubtotal.Text = (a3 + b3 + c3 + d3 + f3 + g3 + h3 + i3 + j3 + k3 + l3 + m3 + n3 + o3 + p3 + q3 + r3 + s3 + t3 + u3 + v3 + w3).ToString();

        //lbquantity22.Visible = true;
        //lbitem22.Visible = true;
        //lbrate22.Visible = true;
        //lbinr22.Visible = true;
        //lbinrr22.Visible = true;
        //lbrateonly22.Visible = true;
        Panel50.Visible = true;
        lbquantity22.Text = TextBox22.Text;
        lbitem22.Text = lbitemname22.Text;
        lbrate22.Text = lbprice22.Text;
        lbrateonly22.Text = lbprice22.Text;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (lbsubtotal.Text == "0.00")
        {

            lberror.Text = "Do Order First.";
        }
        else if (lbsubtotal.Text == "0.0")
        {

            lberror.Text = "Do Order First.";
        }
        else if (lbsubtotal.Text == "0")
        {

            lberror.Text = "Do Order First.";
        }
    }
}