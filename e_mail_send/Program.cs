using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;


namespace e_mail_send
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage mailMessage = new MailMessage("mauriciojuniorrosa8@gmail.com","milesheremau@gmail.com");
            mailMessage.Subject = "Test";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<p>Text exemple!</p>";
            mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("","");

            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);
        }
    }
}
