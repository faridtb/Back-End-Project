using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Allup.Extentions
{
    public class EmailService
    {
        private readonly string _privateEmail;
        private readonly string _privatePassword;

        public EmailService(string privateEmail, string privatePassword)
        {
            _privateEmail = privateEmail;
            _privatePassword = privatePassword;
        }


        public bool SendEmail(string UserEmail,string content = null)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_privateEmail);
            mailMessage.To.Add(new MailAddress(UserEmail));

            mailMessage.Subject = "Invoice";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = content;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(_privateEmail, _privatePassword);
            client.Host = "smtp.mail.ru";
            client.EnableSsl = true;
            client.Port = 587;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (System.Exception)
            {


            }

            return false;
        }
    }
}
