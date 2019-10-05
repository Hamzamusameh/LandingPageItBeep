using LandingPageItBeep.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace LandingPageItBeep.Helpers
{
    public static class EmailSender
    {
        public static int SendEmail(Email email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email.Receiver);
                mail.From = new MailAddress("hamzamusameh2@gmail.com");
                mail.Subject = "itBeepLanding";
                mail.Body = $"العرض رقم {email.Offer} فترة {email.Duration}";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential("hamzamusameh2@gmail.com", "H2014902080h");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
    }
}
