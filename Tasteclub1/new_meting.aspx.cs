using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class new_meting : System.Web.UI.Page
{
    string newguid = System.Guid.NewGuid().ToString("N").Substring(0, 6);
    int mani,z,nm;
    string gen;

    int final1 = 0;
    int total1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            Label1.Text = Session["firstname"].ToString();
            Label3.Text = Session["email"].ToString();
            if (!IsPostBack)
            {
                if (Session["login"].ToString() == "1") { }
                else { Response.Redirect("~/login.aspx"); }
                Label4.Text = "0";
            }

            getdata1();
            lblmenu.Text = lbmndy.Text;
            Session["orderfordate"] = lbmndydate.Text;
            currentpanelll();
            showselecteditems();
        //}
        //catch (Exception e1)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/login.aspx"); 
        //}
    }

    private void getdata1()
    {

        //try 
        //{
            Panel1.BackColor = System.Drawing.Color.Red;
            Panel1.ForeColor = System.Drawing.Color.White;

            if (System.DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {

                lbmndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");
                lbmndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();

                lbtsdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                lbtsdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");


                lbwndy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                lbwndydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

            }

            if (System.DateTime.Now.DayOfWeek.ToString() == "Friday")
            {
                if (System.DateTime.Now.Hour < 11)
                {
                    lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                    lbtsdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");


                }
                else if (System.DateTime.Now.Hour > 11)
                {
                    lbmndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbmndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");
                    lbtsdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                    lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                }
                else
                {
                    if (System.DateTime.Now.Hour == 11)
                    {
                        if (System.DateTime.Now.Minute > 30)
                        {
                            lbmndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbmndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");
                            lbtsdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                            lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(6).AddHours(13).AddMinutes(30).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");


                        }
                        else
                        {
                            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                            lbtsdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                        }
                    }
                }






            }

            if (System.DateTime.Now.DayOfWeek.ToString() == "Thursday")
            {
                if (System.DateTime.Now.AddHours(13).AddMinutes(30).Hour < 11)
                {
                    lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                    lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");


                }
                else if (System.DateTime.Now.Hour > 11)
                {
                    lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                    lbtsdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                }
                else
                {
                    if (System.DateTime.Now.Hour == 11)
                    {
                        if (System.DateTime.Now.Minute > 30)
                        {
                            lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                            lbtsdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");


                        }
                        else
                        {
                            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                            lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");


                        }
                    }
                }



            }

            if (System.DateTime.Now.DayOfWeek.ToString() == "Wednesday")
            {
                if (System.DateTime.Now.Hour < 11)
                {
                    lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                    lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");


                }
                else if (System.DateTime.Now.Hour > 11)
                {
                    lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                    lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                }
                else
                {
                    if (System.DateTime.Now.Hour == 11)
                    {
                        if (System.DateTime.Now.Minute > 30)
                        {
                            lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                            lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                        }
                        else
                        {
                            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();
                            lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                        }
                    }
                }



            }

            if (System.DateTime.Now.DayOfWeek.ToString() == "Tuesday")
            {
                if (System.DateTime.Now.Hour < 11)
                {
                    lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();

                    lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                }
                else if (System.DateTime.Now.Hour > 11)
                {
                    lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();

                    lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                }
                else
                {
                    if (System.DateTime.Now.Hour == 11)
                    {
                        if (System.DateTime.Now.Minute > 30)
                        {
                            lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();

                            lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");


                        }
                        else
                        {
                            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();

                            lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(6).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(6).ToString("MMMM dd");

                        }
                    }
                }

            }
            if (System.DateTime.Now.DayOfWeek.ToString() == "Monday")
            {
                if (System.DateTime.Now.Hour < 11)
                {
                    lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();

                    lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                }
                else if (System.DateTime.Now.Hour > 11)
                {
                    lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                    lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();

                    lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                    lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                    lbwndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                    lbwndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                    lbthdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                    lbthdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                    lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                    lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");

                }
                else
                {
                    if (System.DateTime.Now.Hour == 11)
                    {
                        if (System.DateTime.Now.Minute > 30)
                        {
                            lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();

                            lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(7).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(7).ToString("MMMM dd");


                        }
                        else
                        {
                            lbmndydate.Text = System.DateTime.Now.ToString("MMMM dd");
                            lbmndy.Text = System.DateTime.Now.DayOfWeek.ToString();

                            lbtsdy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();
                            lbtsdydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");


                            lbwndy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                            lbwndydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");

                            lbthdy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                            lbthdydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                            lbfdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                            lbfdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                        }
                    }
                }

            }
            if (System.DateTime.Now.DayOfWeek.ToString() == "Sunday")
            {
                lbmndydate.Text = System.DateTime.Now.AddDays(1).ToString("MMMM dd");
                lbmndy.Text = System.DateTime.Now.AddDays(1).DayOfWeek.ToString();

                lbtsdy.Text = System.DateTime.Now.AddDays(2).DayOfWeek.ToString();
                lbtsdydate.Text = System.DateTime.Now.AddDays(2).ToString("MMMM dd");


                lbwndy.Text = System.DateTime.Now.AddDays(3).DayOfWeek.ToString();
                lbwndydate.Text = System.DateTime.Now.AddDays(3).ToString("MMMM dd");

                lbthdy.Text = System.DateTime.Now.AddDays(4).DayOfWeek.ToString();
                lbthdydate.Text = System.DateTime.Now.AddDays(4).ToString("MMMM dd");

                lbfdy.Text = System.DateTime.Now.AddDays(5).DayOfWeek.ToString();
                lbfdydate.Text = System.DateTime.Now.AddDays(5).ToString("MMMM dd");

            }
        //}
        //catch(Exception e2)
        //{ ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('something is wrong please try again')</script>"); Response.Redirect("~/new_meting.aspx"); }
    }


    public void deletefunction()
    {
        //try
        //{

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmddeletetemporary = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
            cmddeletetemporary.ExecuteNonQuery();

            SqlCommand cmddeletetetemporaryfoodorder = new SqlCommand("delete from temporary_food_order where email='" + Session["email"] + "'", con);
            cmddeletetetemporaryfoodorder.ExecuteNonQuery();

            Label4.Text = "0";

            lbsubtotal.Text = "0";

            //con.Close();
        //}
        //catch (Exception e3)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again...')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
    }

   

    protected void lk_Click(object sender, EventArgs e)
    {
        try
        {
            lblmenu.Text = lbmndy.Text;
            Panel1.BackColor = System.Drawing.Color.Red;
            Panel1.ForeColor = System.Drawing.Color.White;
            Panel2.BackColor = System.Drawing.Color.White;
            Panel2.ForeColor = System.Drawing.Color.Black;
            Panel3.BackColor = System.Drawing.Color.White;
            Panel3.ForeColor = System.Drawing.Color.Black;
            Panel4.BackColor = System.Drawing.Color.White;
            Panel4.ForeColor = System.Drawing.Color.Black;
            Panel5.BackColor = System.Drawing.Color.White;
            Panel5.ForeColor = System.Drawing.Color.Black;
            PlaceHolder1.Controls.Clear();
            PlaceHolder2.Controls.Clear();
            Session["currentpanel"] = "1";
            Session["currentpanel1"] = "0";
            Session["currentpanel2"] = "0";
            Session["currentpanel3"] = "0";
            Session["currentpanel4"] = "0";
            Session["dayofweek"] = lbmndy.Text;
            Session["orderfordate"] = lbmndydate.Text;
            show();
            deletefunction();
        }
        catch (Exception e4)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/new_meting.aspx");
        }
    }
    protected void lk1_Click(object sender, EventArgs e)
    {
        try
        {
            lblmenu.Text = lbtsdy.Text;
            Panel1.BackColor = System.Drawing.Color.White;
            Panel1.ForeColor = System.Drawing.Color.Black;
            Panel2.BackColor = System.Drawing.Color.Red;
            Panel2.ForeColor = System.Drawing.Color.White;
            Panel3.BackColor = System.Drawing.Color.White;
            Panel3.ForeColor = System.Drawing.Color.Black;
            Panel4.BackColor = System.Drawing.Color.White;
            Panel4.ForeColor = System.Drawing.Color.Black;
            Panel5.BackColor = System.Drawing.Color.White;
            Panel5.ForeColor = System.Drawing.Color.Black;
            PlaceHolder1.Controls.Clear();
            PlaceHolder2.Controls.Clear();
            Session["currentpanel"] = "0";
            Session["currentpanel1"] = "1";
            Session["currentpanel2"] = "0";
            Session["currentpanel3"] = "0";
            Session["currentpanel4"] = "0";
            Session["dayofweek"] = lbtsdy.Text;
            Session["orderfordate"] = lbtsdydate.Text;
            show();
            deletefunction();
        }
        catch (Exception e5)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/new_meting.aspx");
        }
    }
    protected void lk2_Click(object sender, EventArgs e)
    {
        try
        {
            lblmenu.Text = lbwndy.Text;
            Panel3.BackColor = System.Drawing.Color.Red;
            Panel3.ForeColor = System.Drawing.Color.White;
            Panel2.BackColor = System.Drawing.Color.White;
            Panel2.ForeColor = System.Drawing.Color.Black;
            Panel1.BackColor = System.Drawing.Color.White;
            Panel1.ForeColor = System.Drawing.Color.Black;
            Panel4.BackColor = System.Drawing.Color.White;
            Panel4.ForeColor = System.Drawing.Color.Black;
            Panel5.BackColor = System.Drawing.Color.White;
            Panel5.ForeColor = System.Drawing.Color.Black;
            PlaceHolder1.Controls.Clear();
            PlaceHolder2.Controls.Clear();
            Session["currentpanel"] = "0";
            Session["currentpanel1"] = "0";
            Session["currentpanel2"] = "1";
            Session["currentpanel3"] = "0";
            Session["currentpanel4"] = "0";
            Session["dayofweek"] = lbwndy.Text;
            Session["orderfordate"] = lbwndydate.Text;
            show();
            deletefunction();
        }
        catch (Exception e6)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/new_meting.aspx");
        }
    }
    protected void lk3_Click(object sender, EventArgs e)
    {
        try
        {
            lblmenu.Text = lbthdy.Text;
            Panel4.BackColor = System.Drawing.Color.Red;
            Panel4.ForeColor = System.Drawing.Color.White;
            Panel2.BackColor = System.Drawing.Color.White;
            Panel2.ForeColor = System.Drawing.Color.Black;
            Panel3.BackColor = System.Drawing.Color.White;
            Panel3.ForeColor = System.Drawing.Color.Black;
            Panel1.BackColor = System.Drawing.Color.White;
            Panel1.ForeColor = System.Drawing.Color.Black;
            Panel5.BackColor = System.Drawing.Color.White;
            Panel5.ForeColor = System.Drawing.Color.Black;
            PlaceHolder1.Controls.Clear();
            PlaceHolder2.Controls.Clear();
            Session["currentpanel"] = "0";
            Session["currentpanel1"] = "0";
            Session["currentpanel2"] = "0";
            Session["currentpanel3"] = "1";
            Session["currentpanel4"] = "0";
            Session["dayofweek"] = lbthdy.Text;
            Session["orderfordate"] = lbthdydate.Text;
            show();
            deletefunction();
        }
        catch (Exception e7)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/new_meting.aspx");
        }
    }
    protected void lk4_Click(object sender, EventArgs e)
    {
        try
        {
            lblmenu.Text = lbfdy.Text;
            Panel5.BackColor = System.Drawing.Color.Red;
            Panel5.ForeColor = System.Drawing.Color.White;
            Panel2.BackColor = System.Drawing.Color.White;
            Panel2.ForeColor = System.Drawing.Color.Black;
            Panel3.BackColor = System.Drawing.Color.White;
            Panel3.ForeColor = System.Drawing.Color.Black;
            Panel4.BackColor = System.Drawing.Color.White;
            Panel4.ForeColor = System.Drawing.Color.Black;
            Panel1.BackColor = System.Drawing.Color.White;
            Panel1.ForeColor = System.Drawing.Color.Black;
            PlaceHolder1.Controls.Clear();
            PlaceHolder2.Controls.Clear();
            Session["currentpanel"] = "0";
            Session["currentpanel1"] = "0";
            Session["currentpanel2"] = "0";
            Session["currentpanel3"] = "0";
            Session["currentpanel4"] = "1";
            Session["dayofweek"] = lbfdy.Text;
            Session["orderfordate"] = lbfdydate.Text;
            show();
            deletefunction();
        }
        catch (Exception e8)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
            Response.Redirect("~/new_meting.aspx");
        }
    }
   

    public void currentpanelll()
    {
        //try
        //{
            if (HttpContext.Current.Session["currentpanel1"] == "1")
            {
                lblmenu.Text = lbtsdy.Text;
                Panel1.BackColor = System.Drawing.Color.White;
                Panel1.ForeColor = System.Drawing.Color.Black;
                Panel2.BackColor = System.Drawing.Color.Red;
                Panel2.ForeColor = System.Drawing.Color.White;
                Panel3.BackColor = System.Drawing.Color.White;
                Panel3.ForeColor = System.Drawing.Color.Black;
                Panel4.BackColor = System.Drawing.Color.White;
                Panel4.ForeColor = System.Drawing.Color.Black;
                Panel5.BackColor = System.Drawing.Color.White;
                Panel5.ForeColor = System.Drawing.Color.Black;
                PlaceHolder1.Controls.Clear();
                Session["dayofweek"] = lbtsdy.Text;
                Session["orderfordate"] = lbtsdy.Text;
                show();
            }
            else if (HttpContext.Current.Session["currentpanel2"] == "1")
            {
                lblmenu.Text = lbwndy.Text;
                Panel3.BackColor = System.Drawing.Color.Red;
                Panel3.ForeColor = System.Drawing.Color.White;
                Panel2.BackColor = System.Drawing.Color.White;
                Panel2.ForeColor = System.Drawing.Color.Black;
                Panel1.BackColor = System.Drawing.Color.White;
                Panel1.ForeColor = System.Drawing.Color.Black;
                Panel4.BackColor = System.Drawing.Color.White;
                Panel4.ForeColor = System.Drawing.Color.Black;
                Panel5.BackColor = System.Drawing.Color.White;
                Panel5.ForeColor = System.Drawing.Color.Black;
                PlaceHolder1.Controls.Clear();
                Session["dayofweek"] = lbwndy.Text;
                Session["orderfordate"] = lbwndydate.Text;
                show();
            }
            else if (HttpContext.Current.Session["currentpanel3"] == "1")
            {
                lblmenu.Text = lbthdy.Text;
                Panel4.BackColor = System.Drawing.Color.Red;
                Panel4.ForeColor = System.Drawing.Color.White;
                Panel2.BackColor = System.Drawing.Color.White;
                Panel2.ForeColor = System.Drawing.Color.Black;
                Panel3.BackColor = System.Drawing.Color.White;
                Panel3.ForeColor = System.Drawing.Color.Black;
                Panel1.BackColor = System.Drawing.Color.White;
                Panel1.ForeColor = System.Drawing.Color.Black;
                Panel5.BackColor = System.Drawing.Color.White;
                Panel5.ForeColor = System.Drawing.Color.Black;
                PlaceHolder1.Controls.Clear();
                Session["dayofweek"] = lbthdy.Text;
                Session["orderfordate"] = lbthdydate.Text;
                show();
            }
            else if (HttpContext.Current.Session["currentpanel4"] == "1")
            {
                lblmenu.Text = lbfdy.Text;
                Panel5.BackColor = System.Drawing.Color.Red;
                Panel5.ForeColor = System.Drawing.Color.White;
                Panel2.BackColor = System.Drawing.Color.White;
                Panel2.ForeColor = System.Drawing.Color.Black;
                Panel3.BackColor = System.Drawing.Color.White;
                Panel3.ForeColor = System.Drawing.Color.Black;
                Panel4.BackColor = System.Drawing.Color.White;
                Panel4.ForeColor = System.Drawing.Color.Black;
                Panel1.BackColor = System.Drawing.Color.White;
                Panel1.ForeColor = System.Drawing.Color.Black;
                PlaceHolder1.Controls.Clear();
                Session["dayofweek"] = lbfdy.Text;
                Session["orderfordate"] = lbfdydate.Text;
                show();
            }
            else
            {
                lblmenu.Text = lbmndy.Text;
                Panel1.BackColor = System.Drawing.Color.Red;
                Panel1.ForeColor = System.Drawing.Color.White;
                Panel2.BackColor = System.Drawing.Color.White;
                Panel2.ForeColor = System.Drawing.Color.Black;
                Panel3.BackColor = System.Drawing.Color.White;
                Panel3.ForeColor = System.Drawing.Color.Black;
                Panel4.BackColor = System.Drawing.Color.White;
                Panel4.ForeColor = System.Drawing.Color.Black;
                Panel5.BackColor = System.Drawing.Color.White;
                Panel5.ForeColor = System.Drawing.Color.Black;
                PlaceHolder1.Controls.Clear();
                Session["dayofweek"] = lbmndy.Text;
                Session["orderfordate"] = lbmndydate.Text;
                show();
            }
        //}
        //catch (Exception e9)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}

    }


        
    private void show()
    {
        //try
        //{
            mani = 1;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmdcountfoods = new SqlCommand("SELECT COUNT(*) FROM food_display", con);
            int totalfooditemsinfoodorder = (int)cmdcountfoods.ExecuteScalar();

            SqlCommand cmdmaximageid = new SqlCommand("select img_id from food_display order by img_id desc", con);
            SqlDataReader drmaximageid = cmdmaximageid.ExecuteReader();
            if (drmaximageid.Read())
            {
                int maximageidinfoodorder = Convert.ToInt32(drmaximageid["img_id"].ToString());

                drmaximageid.Close();

                SqlCommand cmdminimageid = new SqlCommand("select img_id from food_display order by img_id asc", con);
                SqlDataReader drminimageid = cmdminimageid.ExecuteReader();
                if (drminimageid.Read())
                {

                    int minimageidinfoodorder;

                    for (minimageidinfoodorder = Convert.ToInt32(drminimageid["img_id"].ToString()); minimageidinfoodorder <= maximageidinfoodorder; minimageidinfoodorder++)
                    {
                        drminimageid.Close();
                        SqlCommand cmdfetchalldetailsofitem = new SqlCommand("select * from food_display where day='" + lblmenu.Text + "' AND img_id='" + minimageidinfoodorder + "'", con);
                        SqlDataReader drfetchalldetailsofitem = cmdfetchalldetailsofitem.ExecuteReader();
                        if (drfetchalldetailsofitem.Read())
                        {
                            string bookid = drfetchalldetailsofitem["img_id"].ToString();
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

                            string strItemName = drfetchalldetailsofitem["itemname"].ToString();
                            string strCompanyName = drfetchalldetailsofitem["companyname"].ToString();
                            TextBox txt = new TextBox();
                            txt.ID = "txt" + mani.ToString();
                            txt.Height = 50;
                            txt.Width = 50;
                            txt.Attributes.Add("style", "margin-top:9px;float:left;");

                            SqlConnection conQuantity = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
                            conQuantity.Open();
                            SqlCommand cmdQuantity = new SqlCommand("Select totalItems from temporary where itemname='" + drfetchalldetailsofitem["itemname"].ToString() + "'", conQuantity);
                            SqlDataReader drQuantity = cmdQuantity.ExecuteReader();
                            if (drQuantity.Read())
                            {
                                txt.Text = drQuantity[0].ToString();
                            }
                            conQuantity.Close();

                            txt.TextChanged += new EventHandler(txt_TextChanged);
                            txt.Attributes.Add("Style", "margin-top: 9px; float: left;");
                            p.Controls.Add(txt);

                            HyperLink hll = new HyperLink();
                            hll.ImageUrl = (string.Format("~/imghandler.ashx?bookid={0}", bookid));
                            hll.NavigateUrl = (string.Format("~/food-show.aspx?bookid={0}", bookid));
                            p.Controls.Add(hll);

                            Label lb = new Label();
                            lb.ID = "lbitemname" + mani.ToString();
                            lb.Text = strItemName;
                            lb.Width = 300;
                            lb.Attributes.Add("style", "font-size: x-large; font-family: Arial, Helvetica, sans-serif; margin:10px 0px 0px 0px;");
                            p.Controls.Add(lb);
                            p.Controls.Add(new LiteralControl("<br/>"));

                            Label lb1 = new Label();
                            lb1.ID = "lb1" + minimageidinfoodorder.ToString();
                            lb1.Text = "" + strCompanyName;
                            lb1.Attributes.Add("style", "margin-left:30px;");
                            lb1.Width = 300;
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

                            drfetchalldetailsofitem.Close();

                            PlaceHolder1.Controls.Add(new LiteralControl("&nbsp"));

                            mani++;
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
        //catch (Exception e10)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
    }


  



    protected void txt_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
            //int m=1;
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
            }
            //lblcount.Text = ab.ToString();
            lbsubtotal.Text = c.ToString();
            Label4.Text = c.ToString();
        //}
        //catch (Exception e11)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
    }




    protected void addtocart_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();

            SqlCommand cmddeletetemporary = new SqlCommand("delete from temporary where email='" + Session["email"] + "'", con);
            cmddeletetemporary.ExecuteNonQuery();
            //SqlCommand cmd1 = new SqlCommand("delete from temporary where email='" + Label3.Text + "'", con);

            // cmd1.ExecuteNonQuery();

            {
                int c = 0;
                for (int i = 1; i <= mani - 1; i++)
                {
                    TextBox txt = PlaceHolder1.FindControl("txt" + i) as TextBox;
                    Label lbprice = PlaceHolder1.FindControl("lbprice" + i) as Label;
                    Label lbitemname = PlaceHolder1.FindControl("lbitemname" + i) as Label;
                    if (txt.Text != "" && lbprice.Text != "")
                    {
                        c = Convert.ToInt32(txt.Text) * Convert.ToInt32(lbprice.Text);
                        SqlCommand cmd = new SqlCommand("insert into temporary values(@id, @fstname, @email, @totalitems, @itemname, @price, @totalrupee, @payment, @subtotal, @date, @orderfordate, @orderfor)", con);
                        cmd.Parameters.AddWithValue("@id", newguid);
                        cmd.Parameters.AddWithValue("@fstname", Label1.Text);
                        cmd.Parameters.AddWithValue("@email", Label3.Text);
                        cmd.Parameters.AddWithValue("@totalitems", txt.Text);
                        cmd.Parameters.AddWithValue("@itemname", lbitemname.Text);
                        cmd.Parameters.AddWithValue("@price", lbprice.Text);
                        cmd.Parameters.AddWithValue("@totalrupee", c.ToString());
                        cmd.Parameters.AddWithValue("@payment", "No");
                        cmd.Parameters.AddWithValue("@subtotal", lbsubtotal.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@orderfordate", Session["orderfordate"]);
                        cmd.Parameters.AddWithValue("@orderfor", Session["dayofweek"]);
                        cmd.ExecuteNonQuery();
                    }
                }
                Session["foodtotal"] = lbsubtotal.Text;
                Session["newguid"] = newguid;
                Label4.Text = lbsubtotal.Text;
            }
            showselecteditems();
            con.Close();
        //}
        //catch (Exception e12)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            string str = ((Button)sender).ID;
            str = str.Substring(str.Length - 10);
            SqlCommand temporaryselecteditems = new SqlCommand("delete from temporary where email='" + Session["email"].ToString() + "' AND d='" + str + "'", con);// AND itemname='" + lbitemname + "'
            temporaryselecteditems.ExecuteNonQuery();


            Label l4 = PlaceHolder2.FindControl("l4" + Convert.ToInt32(str)) as Label;


            int newsubtotal = Convert.ToInt32(lbsubtotal.Text) - Convert.ToInt32((l4.Text));
            lbsubtotal.Text = newsubtotal.ToString();
            Label4.Text = newsubtotal.ToString();


            SqlCommand cmdupdate = new SqlCommand("update temporary set subtotal=@subtotal where email='" + Session["email"].ToString() + "'", con);
            cmdupdate.Parameters.AddWithValue("@subtotal", lbsubtotal.Text);
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
            Session["foodtotal"] = lbsubtotal.Text;
            showselecteditems();
            con.Close();
        //}
        //catch (Exception e13)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
    }





    protected void Button1_Click(object sender, EventArgs e)
    {
        //try
        //{
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();


            SqlCommand cmdcheckitemintemporary = new SqlCommand("select subtotal from temporary where email='" + Session["email"] + "'", con);
            SqlDataReader drcheckitemintemporary = cmdcheckitemintemporary.ExecuteReader();
            if (drcheckitemintemporary.Read())
            {
                drcheckitemintemporary.Close();
                Response.Redirect("~/Default4.aspx");
            }
            else
            {
                drcheckitemintemporary.Close();
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Please select an item.')</script>");

                Label4.Text = "0";
                lbsubtotal.Text = "0";
            }
        //}
        //catch (Exception e14)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
        
    }


   


     public void showselecteditems()
    {
        //try
        //{
            int i1;
            PlaceHolder2.Controls.Clear();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand newcommand = new SqlCommand("select d from temporary where email='" + Session["email"] + "' order by d desc", con);//where id='" + newguid + "'
            SqlDataReader dr2 = newcommand.ExecuteReader();
            if (dr2.Read())
            {
                int max = Convert.ToInt32(dr2[0].ToString());


                dr2.Close();
                SqlCommand c1 = new SqlCommand("select d from temporary where email='" + Session["email"] + "' order by d asc", con);//where id='" + newguid + "' 
                SqlDataReader dr3 = c1.ExecuteReader();
                if (dr3.Read())
                {
                    int min = Convert.ToInt32(dr3[0].ToString());

                    dr3.Close();
                    for (i1 = min; i1 <= max; i1++)
                    {
                        SqlCommand cmd = new SqlCommand("select * from temporary where d='" + i1 + "' AND email='" + Session["email"] + "'", con);// AND id='" + newguid + "' 
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
                            l.Width = 35;
                            p1.Controls.Add(l);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            Label l1 = new Label();
                            l1.ID = "l1" + i1.ToString();
                            l1.Text = dr4["itemname"].ToString();
                            l1.Attributes.Add("style", "width:239px; float:left;");
                            l1.Font.Size = 12;
                            p1.Controls.Add(l1);
                            p1.Controls.Add(new LiteralControl("&nbsp"));


                            Button btndelete = new Button();
                            btndelete.Click += Button2_Click;
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


                            Label ajay = new Label();
                            ajay.ID = "ajay" + i1.ToString();
                            ajay.Text = dr4["d"].ToString();
                            ajay.Attributes.Add("style", "float:left");
                            ajay.Font.Size = 12;
                            ajay.Visible = false;
                            p1.Controls.Add(ajay);
                            p1.Controls.Add(new LiteralControl("&nbsp"));

                            dr4.Close();
                            PlaceHolder2.Controls.Add(new LiteralControl());
                        }
                        else
                        {
                            dr4.Close();
                        }
                    }
                }
                else
                {
                    dr3.Close();
                }
            }
            else
            {
                dr2.Close();
            }
            SqlCommand cmdsubtotal = new SqlCommand("select subtotal from temporary where email='" + Session["email"] + "'", con);
            SqlDataReader drsubtotal = cmdsubtotal.ExecuteReader();
            if (drsubtotal.Read())
            {
                Label4.Text = drsubtotal["subtotal"].ToString();
                lbsubtotal.Text = drsubtotal["subtotal"].ToString();
                drsubtotal.Close();
            }
            else
            {
                drsubtotal.Close();
            }
       // }
        //catch (Exception e15)
        //{
        //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
        //    Response.Redirect("~/new_meting.aspx");
        //}
     }








    protected void btnlogout_Click(object sender, EventArgs e)
     {
         //try
         //{
             deletefunction();

             Session["currentpanel"] = "0";
             Session["currentpanel1"] = "0";
             Session["currentpanel2"] = "0";
             Session["currentpanel3"] = "0";
             Session["currentpanel4"] = "0";

             Session["login"] = "0";
             Response.Redirect("~/login.aspx");
         //}
         //catch (Exception e16)
         //{
         //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Oops! something is wrong. Please check your internet connection and login again.')</script>");
         //    Response.Redirect("~/new_meting.aspx");
         //}
    }

   
}