using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Email
{
    public class Email
    {
        public void Mail(string sendmailAdress, string subject, string callbackurl, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("neslhnalcoglu@gmail.com", "37363736");
            client.Port = 587;

            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;


            mail.To.Add(sendmailAdress);
            mail.From = new MailAddress("neslhnalcoglu@gmail.com");

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            client.Send(mail);

        }
    }
}
