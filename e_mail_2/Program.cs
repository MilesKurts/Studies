﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace e_mail_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var outlook = new Email("smtp.office365.com", "milesheremau@gmail.com", "Eunovo123");
            outlook.SendEmail(new List<string>
            {
                "mauriciojuniorrosa8@gmail.com"
            },
            subject: "test",
            body: "Segue anexo",
            attachements: new List<string>
            {

            }
            );
        }
    }
}
