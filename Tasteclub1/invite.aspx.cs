using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    //protected string ToEmail, Subj, Message;

    protected string toEmail, EmailSubj, EmailMsg;

    protected void Page_Load(object sender, EventArgs e)
    {
        //lbname.Text = Session["s"].ToString();
        //Label3.Text = Session["e"].ToString();
        //if (!IsPostBack)
        //{
        //    abc();
        //}
    }






    //public void abc()
    //{
    //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand("select id from referral where fstname='" + lbname.Text + "' and name_email='" + Label3.Text + "' order by id asc", con);
    //    SqlDataReader dr = cmd.ExecuteReader();
    //    if (dr.Read())
    //    {
    //        int min = Convert.ToInt32(dr["id"].ToString());
    //        dr.Close();
    //        cmd = new SqlCommand("select id from referral where fstname='" + lbname.Text + "' and name_email='" + Label3.Text + "' order by id desc", con);
    //        SqlDataReader dr1 = cmd.ExecuteReader();
    //        if (dr1.Read())
    //        {
    //            int max = Convert.ToInt32(dr1["id"].ToString());
    //            dr1.Close();
    //            for (int i = min; i <= max; i++)
    //            {
    //                cmd = new SqlCommand("select * from referral where fstname='" + lbname.Text + "' and name_email='" + Label3.Text + "' and id='" + i + "'", con);
    //                SqlDataReader dr2 = cmd.ExecuteReader();
    //                if (dr2.Read())
    //                {
    //                    Label newLabel = new Label();
    //                    newLabel.ID = "lb" + i.ToString();
    //                    newLabel.Attributes.Add("style", " width:auto; font-size:18px; margin-bottom:20px;");
    //                    newLabel.Text = dr2["email"].ToString();
    //                    Panel1.Controls.Add(newLabel);
    //                    Panel1.Controls.Add(new LiteralControl("<br/>"));

    //                    Label newLabel2 = new Label();
    //                    newLabel2.ID = "lb1" + i.ToString();
    //                    newLabel2.Attributes.Add("style", " width:auto; font-size:18px; margin-bottom:20px;");
    //                    newLabel2.Text = dr2["date"].ToString();
    //                    Panel2.Controls.Add(newLabel2);
    //                    Panel2.Controls.Add(new LiteralControl("<br/>"));

    //                    //Label newLabel3 = new Label();
    //                    //newLabel3.ID = "lb2" + i.ToString();
    //                    //newLabel3.Attributes.Add("style", " width:auto; font-size:18px; margin-bottom:20px;");
    //                    //newLabel3.Text = dr2["invited"].ToString();
    //                    //Panel3.Controls.Add(newLabel3);
    //                    //Panel3.Controls.Add(new LiteralControl(","));
    //                    //Panel3.Controls.Add(new LiteralControl("&nbsp"));

    //                    //Label newLabel4 = new Label();
    //                    //newLabel4.ID = "lb2" + i.ToString();
    //                    //newLabel4.Attributes.Add("style", " width:auto; font-size:18px; margin-bottom:20px;");
    //                    //newLabel4.Text = dr2["Joined"].ToString();
    //                    //Panel3.Controls.Add(newLabel4);
    //                    //Panel3.Controls.Add(new LiteralControl("&nbsp"));

    //                    //LinkButton h1 = new LinkButton();
    //                    //h1.ID = "lb2" + i.ToString();
    //                    //h1.Click += LinkButton1_Click;
    //                    //h1.Attributes.Add("style", " width:auto; font-size:18px; margin-bottom:20px;");
    //                    //h1.Text = "Remind";
    //                    //Panel3.Controls.Add(h1);
    //                    //Panel3.Controls.Add(new LiteralControl("<br/>"));
    //                    dr2.Close();





    //                }
    //                else
    //                {
    //                    dr2.Close();
    //                }

    //            }
    //        }
    //    }
    //}


    protected void Button1_Click(object sender, EventArgs e)
    {
        toEmail = txttomail.Text;
        EmailSubj = Convert.ToString(txtsub.Text) + lbname.Text + "Invites you to TASTE Club";
        EmailMsg = Convert.ToString(txtmsg.Text);

        SendEmail.Email_Without_Attachment(toEmail, EmailSubj, EmailMsg);

        string[] lines = txttomail.Text.Split(',');

        for (int i = 0; i < lines.Length; i++)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into referral values(@fstname, @name_email, @email, @date, @invited, @joined)", con);
            cmd.Parameters.AddWithValue("@fstname", lbname.Text);
            cmd.Parameters.AddWithValue("@name_email", Label3.Text);
            cmd.Parameters.AddWithValue("@email", lines[i]);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@invited", "Invited");
            cmd.Parameters.AddWithValue("@joined", "Not Joined");
            cmd.ExecuteNonQuery();
            con.Close();

            txttomail.Text = "";
            txtsub.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('email  sent');", true);
        }
        //ToEmail = txttomail.Text;
        //Subj = lbname.Text + "Invites you to TASTE Club";
        //Message = Convert.ToString(txtmsg.Text);
        ////passing parameter to Email Method
        //SendEmail.Email_Without_Attachment(ToEmail, Subj, Message);


        //string[] lines = txttomail.Text.Split(',');

        //for (int i = 0; i < lines.Length; i++)
        //{

        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("insert into referral values(@fstname, @name_email, @email, @date, @invited, @joined)", con);
        //    cmd.Parameters.AddWithValue("@fstname", lbname.Text);
        //    cmd.Parameters.AddWithValue("@name_email", Label3.Text);
        //    cmd.Parameters.AddWithValue("@email", lines[i]);
        //    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
        //    cmd.Parameters.AddWithValue("@invited", "Invited");
        //    cmd.Parameters.AddWithValue("@joined", "Not Joined");
        //    cmd.ExecuteNonQuery();
        //}
        //abc();
        //txttomail.Text = "";
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txttomail.Text = "";
        txtsub.Text = "";
    }
    //protected void LinkButton1_Click(object sender, EventArgs e)
    //{

    //}
}