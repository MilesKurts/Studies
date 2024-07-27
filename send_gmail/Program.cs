using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace send_gmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fromMail = Console.ReadLine();
            string fromPassword = Console.ReadLine();

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Test subject";
            message.To.Add(new MailAddress(fromMail));
            message.Body = "<html><body> Test Body</body></html>";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
            };
            try
            {
                smtpClient.Send(message);
                Console.WriteLine("Certo");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
            
            Console.ReadKey();
           


        }
    }
}
