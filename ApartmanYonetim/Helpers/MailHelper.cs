using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.Helpers
{
    internal class MailHelper
    {
        public static void MailGonder(string mail, string sifre)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("seymanurr2134@gmail.com");
            mesaj.To.Add(mail);

            mesaj.Subject = "Apartman Sistem Giriş Bilgileri";

            mesaj.Body = "Sisteme giriş şifreniz: " + sifre;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("seymanurr2134@gmail.com", "pyoj cygb bxbr bbhx");
            smtp.EnableSsl = true;

            smtp.Send(mesaj);
        }
    }
}
