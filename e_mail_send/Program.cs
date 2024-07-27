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
            mailMessage.From = new MailAddress("your-email@example.com");
            mailMessage.To.Add("recipient-email@example.com");
            mailMessage.Subject = "Test Email";
            mailMessage.Body = "<p>Text example!</p>";
            mailMessage.IsBodyHtml = true;

            // Create the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.example.com", 587);
            smtpClient.Credentials = new NetworkCredential("your-email@example.com", "your-email-password");
            smtpClient.EnableSsl = true;

            // Send the email
            try
            {
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
