using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class skdslider_Default4 : System.Web.UI.Page
{
    int mani, grandtotal;
    string guid;
    int a;
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{

            Label1.Text = Session["firstname"].ToString();
            Label3.Text = Session["email"].ToString();
            Label4.Text = Session["foodtotal"].ToString();


            guid = Session["newguid"].ToString();

            grandtotal = Convert.ToInt32(lbsubtotal1.Text) + Convert.ToInt32(Label4.Text);


            if (!IsPostBack)
            {
            }
            show();
            // id();
            showselecteditems();

        //}
        //catch (Exception e1)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/login.aspx");
        //}
    }



    private void show()
    {
        //try
        //{
            mani = 1;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();


            SqlCommand cmdcountfoods = new SqlCommand("SELECT COUNT(*) FROM beverages", con);
            int totalfooditemsinfoodorder = (int)cmdcountfoods.ExecuteScalar();



            SqlCommand cmdmaximageid = new SqlCommand("select img_id from beverages order by img_id desc", con);
            SqlDataReader drmaximageid = cmdmaximageid.ExecuteReader();
            if (drmaximageid.Read())
            {
                int maximageidinfoodorder = Convert.ToInt32(drmaximageid["img_id"].ToString());

                drmaximageid.Close();

                SqlCommand cmdminimageid = new SqlCommand("select img_id from beverages order by img_id asc", con);
                SqlDataReader drminimageid = cmdminimageid.ExecuteReader();
                if (drminimageid.Read())
                {

                    int minimageidinfoodorder;


                    for (minimageidinfoodorder = Convert.ToInt32(drminimageid["img_id"].ToString()); minimageidinfoodorder <= maximageidinfoodorder; minimageidinfoodorder++)
                    {
                        drminimageid.Close();
                        SqlCommand cmdfetchalldetailsofitem = new SqlCommand("select * from beverages where img_id='" + minimageidinfoodorder + "'", con);
                        SqlDataReader drfetchalldetailsofitem = cmdfetchalldetailsofitem.ExecuteReader();
                        if (drfetchalldetailsofitem.Read())
                        {
                            string bookida = drfetchalldetailsofitem["img_id"].ToString();
                            Panel p = new Panel();
                            p.ID = "pan" + Guid.NewGuid().ToString("N");
                            p.Attributes.Add("style", " width:700px;  height:130px; float:left; margin-left:10px; margin-bottom:10px; border-bottom:1px solid #cccccc;");
                            p.Visible = true;
                            PlaceHolder1.Controls.Add(p);


                            Label lblqty = new Label();
                            lblqty.ID = "lblqty" + mani.ToString();
                            lblqty.Text = "qty";
                            lblqty.Attributes.Add("style", "position: relative; left:-310px; top:50px;");
                            p.Controls.Add(lblqty);

                            TextBox txt = new TextBox();
                            txt.ID = "txt" + mani.ToString();
                            txt.Height = 50;
                            txt.Width = 50;


                            txt.TextChanged += new EventHandler(txt_TextChanged);
                            txt.Attributes.Add("Style", "margin-top: 9px; float: left;");
                            p.Controls.Add(txt);

                            HyperLink hlla = new HyperLink();
                            hlla.ImageUrl = (string.Format("~/Handler1.ashx?bookid={0}", bookida));

                            hlla.NavigateUrl = (string.Format("~/food_show1.aspx?bookid={0}", bookida));
                            p.Controls.Add(hlla);

                            //HyperLink hyper = new HyperLink();
                            //hyper.Text = "" + dr["firm_name"].ToString();
                            //hyper.Width = 450;
                            //hyper.Font.Size = 18;
                            //hyper.NavigateUrl = (string.Format("~/detail.aspx?bookid={0}", bookid));
                            //p.Controls.Add(hyper);
                            //p.Controls.Add(new LiteralControl("<br/>"));

                            Label lb = new Label();
                            lb.ID = "lbitemname" + mani.ToString();
                            lb.Text = drfetchalldetailsofitem["itemname"].ToString();
                            lb.Width = 300;
                            lb.Attributes.Add("style", "font-size: x-large; font-family: Arial, Helvetica, sans-serif; margin:10px 0px 0px 0px;");
                            p.Controls.Add(lb);
                            p.Controls.Add(new LiteralControl("<br/>"));

                            Label lb1 = new Label();
                            lb1.ID = "lb1" + minimageidinfoodorder.ToString();
                            lb1.Text = "" + drfetchalldetailsofitem["companyname"].ToString();
                            lb1.Attributes.Add("style", "margin-left:30px;");
                            lb1.Width = 230;
                            p.Controls.Add(lb1);
                            p.Controls.Add(new LiteralControl("<br/>"));

                            Label lb3 = new Label();
                            lb3.ID = "lbrupee" + mani.ToString();
                            lb3.Width = 0;
                            lb3.Attributes.Add("style", "color: #51ae8c; font-weight: 500; font-size: 1.125em; margin-left:30px;");
                            lb3.Text = "Rs. ";
                            p.Controls.Add(lb3);





                            Button addtocart = new Button();
                            addtocart.Click += addtocart_Click;
                            addtocart.ID = "addtocart" + mani.ToString();
                            addtocart.Height = 30;
                            addtocart.Width = 110;
                            addtocart.Text = "Add To Cart";
                            addtocart.Attributes.Add("style", "float:right;");
                            p.Controls.Add(addtocart);

                            Label lb2 = new Label();
                            lb2.ID = "lbprice" + mani.ToString();
                            lb2.Width = 300;
                            lb2.Attributes.Add("style", "color: #51ae8c; font-weight: 500; font-size: 1.125em; margin-left:30px;");
                            lb2.Text = drfetchalldetailsofitem["price"].ToString();
                            p.Controls.Add(lb2);

                            mani++;
                            drfetchalldetailsofitem.Close();
                            PlaceHolder1.Controls.Add(new LiteralControl("&nbsp"));
                        }
                        else
                        {
                            drfetchalldetailsofitem.Close();
                        }
                    }
                    drminimageid.Close();
                }
                else
                {
                    drminimageid.Close();
                }
            }
            else
            {
                drmaximageid.Close();
            }
        //}
        //catch (Exception e2)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }
   

    //private void id()
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    //        con.Open();
    //        SqlCommand c = new SqlCommand("select d from temporary_food_order where id='" + guid + "'order by d desc", con);
    //        SqlDataReader dr2 = c.ExecuteReader();
    //        if (dr2.Read())
    //        {


    //            int max = Convert.ToInt32(dr2[0].ToString());
    //            dr2.Close();

    //            SqlCommand c1 = new SqlCommand("select d from temporary_food_order where id='" + guid + "' order by d asc", con);
    //            SqlDataReader dr3 = c.ExecuteReader();
    //            if (dr3.Read())
    //            {

    //                int min = Convert.ToInt32(dr3[0].ToString());
    //                dr3.Close();

    //                for (int i1 = 1; i1 <= max; i1++)
    //                {
    //                    SqlCommand cmd = new SqlCommand("select * from temporary_food_order where id='" + guid + "' and d='" + i1 + "'", con);
    //                    SqlDataReader dr4 = cmd.ExecuteReader();
    //                    if (dr4.Read())
    //                    {
    //                        Panel p1 = new Panel();
    //                        p1.ID = "panel" + i1.ToString();
    //                        p1.Attributes.Add("style", " width:395px;  height:auto; float:left; margin:10px;");
    //                        PlaceHolder2.Controls.Add(p1);

    //                        Label l = new Label();
    //                        l.ID = "l" + i1.ToString();
    //                        l.Text = dr4["totalitems"].ToString();
    //                        l.Attributes.Add("style", "float:left");
    //                        l.Font.Size = 12;
    //                        l.Width = 20;
    //                        p1.Controls.Add(l);
    //                        p1.Controls.Add(new LiteralControl("&nbsp"));

    //                        Label l1 = new Label();
    //                        l1.ID = "l1" + i1.ToString();
    //                        l1.Text = dr4["itemname"].ToString();
    //                        l1.Attributes.Add("style", "width:190px; float:left; margin-left:5px;");
    //                        l1.Font.Size = 12;
    //                        p1.Controls.Add(l1);
    //                        p1.Controls.Add(new LiteralControl("&nbsp"));

    //                        Label l4 = new Label();
    //                        l4.ID = "l4" + i1.ToString();
    //                        l4.Text = dr4["totalrupee"].ToString();
    //                        l4.Attributes.Add("style", "float:left");
    //                        l4.Font.Size = 12;
    //                        p1.Controls.Add(l4);
    //                        p1.Controls.Add(new LiteralControl("&nbsp"));

    //                        dr4.Close();
    //                        PlaceHolder2.Controls.Add(new LiteralControl());
    //                    }
    //                    else
    //                    {
    //                        dr4.Close();
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                dr2.Close();
    //            }
    //            con.Close();
    //        }
    //    }
    //    catch (Exception e3)
    //    {
    //        ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
    //        Response.Redirect("~/Default4.aspx");
    //    }
    //}




    protected void txt_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
            int ab = 0;
            int c = 0;

            for (int i = 1; i <= mani - 1; i++)
            {
                TextBox txt = PlaceHolder1.FindControl("txt" + i) as TextBox;
                Label lbprice = PlaceHolder1.FindControl("lbprice" + i) as Label;
                if (txt.Text != "" && lbprice.Text != "")
                {
                    c += Convert.ToInt32(txt.Text) * Convert.ToInt32(lbprice.Text);
                    ab += Convert.ToInt32(txt.Text);
                }
                else
                { }
            }
            lbsubtotal1.Text = c.ToString();
            grandtotal = Convert.ToInt32(lbsubtotal1.Text) + Convert.ToInt32(Label4.Text);
        //}
        //catch (Exception e4)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmds = new SqlCommand("select d from temporary where id='" + guid + "'order by d desc", con);
            SqlDataReader drs = cmds.ExecuteReader();
            if (drs.Read())
            {
                int max1 = Convert.ToInt32(drs[0].ToString());
                drs.Close();

                SqlCommand c1 = new SqlCommand("select d from temporary where id='" + guid + "' order by d asc", con);
                SqlDataReader dr3 = c1.ExecuteReader();
                if (dr3.Read())
                {
                    int min1 = Convert.ToInt32(dr3[0].ToString());

                    dr3.Close();
                    for (int i12 = min1; i12 <= max1; i12++)
                    {
                        SqlCommand cmdss = new SqlCommand("select * from temporary where id='" + guid + "' AND d='" + i12 + "'order by d asc", con);
                        SqlDataReader drss = cmdss.ExecuteReader();
                        if (drss.Read())
                        {
                            a = Convert.ToInt32(drss["d"].ToString());
                            int j = Convert.ToInt32(drss["totalitems"].ToString());
                            Label9.Text = drss["itemname"].ToString();
                            int k = Convert.ToInt32(drss["price"].ToString());
                            int l = Convert.ToInt32(drss["totalrupee"].ToString());

                            drss.Close();
                            SqlCommand cmdinsert = new SqlCommand("insert into temp values(@id, @d, @fstname, @email, @totalitems, @itemname, @price, @totalrupee, @payment, @subtotal, @date, @orderfordate, @orderfor)", con);
                            cmdinsert.Parameters.AddWithValue("@id", guid);
                            cmdinsert.Parameters.AddWithValue("@d", a.ToString());
                            cmdinsert.Parameters.AddWithValue("@fstname", Label1.Text);
                            cmdinsert.Parameters.AddWithValue("@email", Label3.Text);
                            cmdinsert.Parameters.AddWithValue("@totalitems", j.ToString());
                            cmdinsert.Parameters.AddWithValue("@itemname", Label9.Text);
                            cmdinsert.Parameters.AddWithValue("@price", k.ToString());
                            cmdinsert.Parameters.AddWithValue("@totalrupee", l.ToString());
                            cmdinsert.Parameters.AddWithValue("@payment", "No");
                            cmdinsert.Parameters.AddWithValue("@subtotal", grandtotal.ToString());
                            cmdinsert.Parameters.AddWithValue("@date", DateTime.Now.Date.ToShortDateString());
                            cmdinsert.Parameters.AddWithValue("@orderfordate", Session["orderfordate"]);
                            cmdinsert.Parameters.AddWithValue("@orderfor", Session["dayofweek"]);
                            cmdinsert.ExecuteNonQuery();

                        }
                        else
                        { drss.Close(); }
                    }
                }
                else
                { dr3.Close(); }
            }
            else
            { drs.Close(); }




            SqlCommand cmd6 = new SqlCommand("select d from temporary_food_order where id='" + guid + "'order by d desc", con);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                int max1 = Convert.ToInt32(dr6[0].ToString());
                dr6.Close();

                SqlCommand c7 = new SqlCommand("select d from temporary_food_order where id='" + guid + "' order by d asc", con);
                SqlDataReader dr7 = c7.ExecuteReader();
                if (dr7.Read())
                {
                    int min1 = Convert.ToInt32(dr7[0].ToString());

                    dr7.Close();
                    for (int i13 = min1; i13 <= max1; i13++)
                    {
                        SqlCommand cmd8 = new SqlCommand("select * from temporary_food_order where id='" + guid + "' AND d='" + i13 + "'order by d desc", con);
                        SqlDataReader dr8 = cmd8.ExecuteReader();
                        if (dr8.Read())
                        {
                            Label12.Text = dr8["d"].ToString();
                            Label13.Text = dr8["totalitems"].ToString();
                            Label14.Text = dr8["itemname"].ToString();
                            Label15.Text = dr8["price"].ToString();
                            Label16.Text = dr8["totalrupee"].ToString();

                            dr8.Close();
                            SqlCommand cmdinsert = new SqlCommand("insert into temp values(@id, @d, @fstname, @email, @totalitems, @itemname, @price, @totalrupee, @payment, @subtotal, @date, @orderfordate, @orderfor)", con);
                            cmdinsert.Parameters.AddWithValue("@id", guid);
                            cmdinsert.Parameters.AddWithValue("@d", Label12.Text);
                            cmdinsert.Parameters.AddWithValue("@fstname", Label1.Text);
                            cmdinsert.Parameters.AddWithValue("@email", Label3.Text);
                            cmdinsert.Parameters.AddWithValue("@totalitems", Label13.Text);
                            cmdinsert.Parameters.AddWithValue("@itemname", Label14.Text);
                            cmdinsert.Parameters.AddWithValue("@price", Label15.Text);
                            cmdinsert.Parameters.AddWithValue("@totalrupee", Label16.Text);
                            cmdinsert.Parameters.AddWithValue("@payment", "No");
                            cmdinsert.Parameters.AddWithValue("@subtotal", grandtotal.ToString());
                            cmdinsert.Parameters.AddWithValue("@date", DateTime.Now.Date.ToShortDateString());
                            cmdinsert.Parameters.AddWithValue("@orderfordate", Session["orderfordate"]);
                            cmdinsert.Parameters.AddWithValue("@orderfor", Session["dayofweek"]);
                            cmdinsert.ExecuteNonQuery();
                        }
                        else
                        { dr8.Close(); }
                    }
                }
                else
                { dr7.Close(); }
            }
            else
            { dr6.Close(); }


            SqlCommand cmddelete = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
            cmddelete.ExecuteNonQuery();

            SqlCommand cmdtemp = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
            cmdtemp.ExecuteNonQuery();

            Response.Redirect("~/Default.aspx?s=" + guid + "");



        //}
        //catch (Exception e5)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
  


    }





    protected void Button2_Click(object sender, EventArgs e)
    {
        //try
        //{
            Response.Redirect("~/new_meting.aspx");
        //}
        //catch (Exception e6)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }



    protected void addtocart_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmddelete = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
            cmddelete.ExecuteNonQuery();

            int c = 0;
            for (int i = 1; i <= mani - 1; i++)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('something is wrong. can't visit next page.')</script>");
                TextBox txt = PlaceHolder1.FindControl("txt" + i) as TextBox;
                Label lbprice = PlaceHolder1.FindControl("lbprice" + i) as Label;
                Label lbitemname = PlaceHolder1.FindControl("lbitemname" + i) as Label;
                if (txt.Text != "" && lbprice.Text != "")
                {
                    c = Convert.ToInt32(txt.Text) * Convert.ToInt32(lbprice.Text);

                    SqlCommand cmd = new SqlCommand("insert into temporary_food_order values(@id, @fstname, @email, @totalitems, @itemname, @price, @totalrupee, @payment, @subtotal, @date, @orderfordate, @orderfor)", con);
                    cmd.Parameters.AddWithValue("@id", guid);
                    cmd.Parameters.AddWithValue("@fstname", Label1.Text);
                    cmd.Parameters.AddWithValue("@email", Label3.Text);
                    cmd.Parameters.AddWithValue("@totalitems", txt.Text);
                    cmd.Parameters.AddWithValue("@itemname", lbitemname.Text);
                    cmd.Parameters.AddWithValue("@price", lbprice.Text);
                    cmd.Parameters.AddWithValue("@totalrupee", c.ToString());
                    cmd.Parameters.AddWithValue("@payment", "No");
                    cmd.Parameters.AddWithValue("@subtotal", grandtotal.ToString());
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@orderfordate", Session["orderfordate"]);
                    cmd.Parameters.AddWithValue("@orderfor", Session["dayofweek"]);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("update temporary_food_order set subtotal=@subtotal where id='" + guid + "'", con);
                    cmd1.Parameters.AddWithValue("@subtotal", grandtotal.ToString());
                    cmd1.ExecuteNonQuery();
                }
            }
            Session["w"] = lbsubtotal1.Text;

            showselecteditems();
        //}
        //catch (Exception e7)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }


    public void showselecteditems()
    {
        //try
        //{
            PlaceHolder2.Controls.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand newcommand = new SqlCommand("select d from temporary_food_order where id='" + guid + "'order by d desc", con);
            SqlDataReader dr2 = newcommand.ExecuteReader();
            if (dr2.Read())
            {
                int max = Convert.ToInt32(dr2[0].ToString());
                dr2.Close();
                SqlCommand c1 = new SqlCommand("select d from temporary_food_order where id='" + guid + "' order by d asc", con);
                SqlDataReader dr3 = c1.ExecuteReader();
                if (dr3.Read())
                {
                    int min = Convert.ToInt32(dr3[0].ToString());
                    dr3.Close();
                    for (int i1 = min; i1 <= max; i1++)
                    {

                        SqlCommand cmd = new SqlCommand("select * from temporary_food_order where id='" + guid + "' and d='" + i1 + "'", con);
                        SqlDataReader dr4 = cmd.ExecuteReader();
                        if (dr4.Read())
                        {
                            Panel p1 = new Panel();
                            p1.ID = "panel" + i1.ToString();
                            p1.Attributes.Add("style", " width:395px;  height:auto; float:left; margin:10px;");
                            PlaceHolder2.Controls.Add(p1);

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
                            l1.Attributes.Add("style", "font-size: 12pt; width:200px; margin-left:10px; float: left;");
                            l1.Font.Size = 12;
                            p1.Controls.Add(l1);
                            p1.Controls.Add(new LiteralControl("&nbsp"));


                            Button btndelete = new Button();
                            btndelete.Click += Button3_Click;
                            btndelete.ID = "btndelete" + i1.ToString();
                            btndelete.Text = "Cancel";
                            btndelete.Attributes.Add("style", "float: right; margin-right: 16px;");
                            btndelete.Font.Size = 8;
                            p1.Controls.Add(btndelete);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            Label l4 = new Label();
                            l4.ID = "l4" + i1.ToString();
                            l4.Text = dr4["totalrupee"].ToString();
                            l4.Attributes.Add("style", "float:left");
                            l4.Font.Size = 12;
                            p1.Controls.Add(l4);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            dr4.Close();
                            PlaceHolder2.Controls.Add(new LiteralControl());
                        }
                        else
                        { dr4.Close(); }
                    }
                }
                else
                {
                    dr2.Close();
                }
                con.Close();
            }
        //}
        //catch (Exception e8)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }

    public void deletefunction()
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmddelete = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
            cmddelete.ExecuteNonQuery();

            SqlCommand cmdtemp = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
            cmdtemp.ExecuteNonQuery();
        //}
        //catch (Exception e9)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }





    protected void btnlogout_Click(object sender, EventArgs e)
    {
        //try
        //{
            deletefunction();
            Session["login"] = "0";
            Response.Redirect("~/login.aspx");
        //}
        //catch (Exception e10)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            string str = ((Button)sender).ID;
            str = str.Substring(str.Length - 10);
            SqlCommand temporaryselecteditems = new SqlCommand("delete from temporary_food_order where email='" + Session["email"].ToString() + "' AND d='" + str + "'", con);// AND itemname='" + lbitemname + "'
            temporaryselecteditems.ExecuteNonQuery();

            Label l4 = PlaceHolder2.FindControl("l4" + Convert.ToInt32(str)) as Label;


            int newsubtotalofbeverages = Convert.ToInt32(lbsubtotal1.Text) - Convert.ToInt32((l4.Text));
            lbsubtotal1.Text = newsubtotalofbeverages.ToString();
            Label4.Text = newsubtotalofbeverages.ToString();


            SqlCommand cmdupdate = new SqlCommand("update temporary_food_order set subtotal=@subtotal where email='" + Session["email"].ToString() + "'", con);
            cmdupdate.Parameters.AddWithValue("@subtotal", lbsubtotal1.Text);
            cmdupdate.ExecuteNonQuery();

            for (int i = 1; i <= mani - 1; i++)
            {

                Label l1 = PlaceHolder2.FindControl("l1" + Convert.ToInt32(str)) as Label;
                Label lb = PlaceHolder1.FindControl("lbitemname" + i) as Label;
                TextBox txt = PlaceHolder1.FindControl("txt" + i) as TextBox;

                if (l1.Text == lb.Text)
                { txt.Text = ""; }
                else
                { }
            }


            Session["w"] = lbsubtotal1.Text;
            showselecteditems();
            con.Close();
        //}
        //catch (Exception e11)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/Default4.aspx");
        //}
       
    }
}