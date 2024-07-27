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
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("milesheremau@gmail.com");
            mailMessage.To.Add("mauriciojuniorrosa8@gmail.com");
            mailMessage.Subject = "Test Email";
            mailMessage.Body = "<p>Hello Milese!</p>";
            mailMessage.IsBodyHtml = true;

            // Create the SMTP client



            SmtpClient smtpClient = new SmtpClient("milesheremau@gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("milesheremau@gmail.com", "");
            smtpClient.EnableSsl = true;

            // Send the email
            try
            {
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.ReadKey();
        }
    }
}
