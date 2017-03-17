using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
   string name;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sst"].ToString());
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from login where email='" + TextBox1.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
           name = dr["fstname"].ToString();
            string snm = dr["email"].ToString();
         //   string body = this.PopulateBody(name,"Click Here to Reset Your Password", "http://www.tasteclub/reset_password.aspx?n=" + snm + "",
         //"");

            MailMessage sms = new MailMessage();
            sms.To.Add(TextBox1.Text);
            sms.Subject = "You requested a new TASTE Club password";
            sms.From = new System.Net.Mail.MailAddress("info@shrisatyait.com");
            sms.Body = "<div style='background-color:#f4f4f4; height:350px; width:100%; padding:3% 10% 6% 10%;'><div style='height:400px; width:80%; background-color:white;'><div style='height:10px; background-color:#f15832;'></div><div style='padding:5px;'><div style='padding:30px 0px 0px 30px;'><img src='http://tasteclub.in/img/logo.png' style='height:50px; width:50px;'/></div><div>Hello</div><br /><br /><div style='width:60%'>You recently asked to reset your password. Please ignore this email if you do not wish to reset your password.</div><br /><div><a href='http://tasteclub.in/reset_password.aspx?n=" + snm + "'>Click Here to Reset Your Password</a></div><br /><br /><div>Thanks,</div><br /><div>Team Taste Club</div></div></div></div>";
//@"<bgcolor=#336999>Hello " + name + ", <br/><br/>You recently asked to reset your password.<br/>Please ignore this email if you do not wish to reset your password.<br/>Click Here to Reset Your Password.<br/>http://www.tasteclub.in/reset_password.aspx?n=" + snm + "</bgcolor>";
           
            sms.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
          
            //smtp.EnableSsl = true;
            smtp.Host = "mail.shrisatyait.com";
            smtp.Credentials = new System.Net.NetworkCredential("info@shrisatyait.com", "admin@123");
            smtp.Send(sms);

            //feedback auto forward to registerd email

            MailMessage sms1 = new MailMessage();
            sms1.To.Add("vats.nilesh87@gmail.com");
            sms1.Subject = "New Feeback";
            sms1.From = new System.Net.Mail.MailAddress("info@shrisatyait.com");
            sms1.Body = "Hello " + name + " Click Here to Reset Your Password, http://www.tasteclub.in/reset_password.aspx?n=" + snm + "";
            SmtpClient smtp1 = new SmtpClient();
            // smtp.EnableSsl = true;
            smtp1.Host = "mail.shrisatyait.com";
            smtp1.Credentials = new System.Net.NetworkCredential("info@shrisatyait.com", "admin@123");
            smtp1.Send(sms1);
            
           

            //"Here Mudassar Ahmed Khan has explained how to fetch multiple column values i.e." +
            //" ID and Text values in the ASP.Net AJAX Control Toolkit AutocompleteExtender"
            //+ "and also how to fetch the select text and value server side on postback");
            //this.SendHtmlFormattedEmail(TextBox1.Text, "You requested a new TASTE Club password", body);
            Label3.Text = "A password reset email was sent to rajbatra05@gmail.com.";
            TextBox1.Text = "";
        }
        else
        {
            Label3.Text = "Email doesn't exist.";
        }
       
    }

    //private string PopulateBody(string userName, string title, string url, string description)
    //{
    //    string body = string.Empty;
    //    using (StreamReader reader = new StreamReader(Server.MapPath("~/EmailTemplate.htm")))
    //    {
    //        body = reader.ReadToEnd();
    //    }
    //    body = body.Replace("{name}", userName);
    //    body = body.Replace("{Title}", title);
    //    body = body.Replace("{Url}", url);
    //    body = body.Replace("{Description}", description);
    //    return body;
    //}

    //private void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
    //{
    //    using (MailMessage mailMessage = new MailMessage())
    //    {
    //        mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["name"]);

    //        mailMessage.Subject = subject;
    //        mailMessage.Body = body;
    //        mailMessage.IsBodyHtml = true;
    //        mailMessage.To.Add(new MailAddress(recepientEmail));
    //        SmtpClient smtp = new SmtpClient();
    //        smtp.Host = ConfigurationManager.AppSettings["Host"];
    //        smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"]);
    //        System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
    //        NetworkCred.UserName = ConfigurationManager.AppSettings["name"];
    //        NetworkCred.Password = ConfigurationManager.AppSettings["Password"];
    //        smtp.UseDefaultCredentials = true;
    //        smtp.Credentials = NetworkCred;
    //        smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
    //        smtp.Send(mailMessage);
    //    }
    //}
}