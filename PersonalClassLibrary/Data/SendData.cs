using System;
using System.Net;
using System.Net.Mail;

namespace PersonalClassLibrary.Data
{
    class SendData
    {

        /// <summary>
        /// To send an email.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="useHTMLTags"></param>
        /// <param name="port"></param>
        /// <param name="enableSSL"></param>
        /// <returns></returns>
        public static bool SendEmail(string displayName, string[] to, string subject, string body, bool useHTMLTags, int port, bool enableSSL)
        {
            bool flag = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hb.webscraper@gmail.com", displayName);

            foreach (string item in to)
            {
                mail.To.Add(item);
            }
            //mail.To.Add(to);
            mail.Subject = subject;
            //mail.Body = body;
            mail.Attachments.Add(new Attachment(body));
            mail.IsBodyHtml = useHTMLTags;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = port;
            try
            {
                smtp.Credentials = new NetworkCredential("hb.webscraper@gmail.com", "eqmemckezqqxhyrr");
                smtp.EnableSsl = enableSSL;
                smtp.Send(mail);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }

            return flag;
        }

    }
}
