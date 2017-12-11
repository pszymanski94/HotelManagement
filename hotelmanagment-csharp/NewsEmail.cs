using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
//using System.Web.Security;


namespace Hotel
{
    class NewsEmail : Observer
    {
        string title; 
        string description;
        News news;

        public NewsEmail(News news)
        {
            this.news = news;
        }
        public void update()
        {
            title = news.getTitle();
            description = news.getDescription();

            var message = new MailMessage();
            message.From = new MailAddress("od@kogo.pl", "Adres od");
            message.To.Add(new MailAddress("do@kogo.pl"));
            message.Subject = title;
            message.Body = description;


            var smtp = new SmtpClient("stmp.servernadawcy.pl");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("nazwa@nadawcy.pl", "haslonadawcy");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(message);
            MessageBox.Show("Wyslano maila!");
        }
    }
}

