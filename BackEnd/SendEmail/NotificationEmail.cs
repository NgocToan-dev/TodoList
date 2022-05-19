using System;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    public class NotificationEmail
    {
        public NotificationEmail()
        {

        }
        public void sendEmail()
        {
            string from, to, pass, content;
            from = "testsendemail111@gmail.com";
            to = "pntoan156@gmail.com";
            pass = "Toan@123456";
            content = "Chào Toản. Test thử email";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = "Đây là email test thử chức năng gửi email bằng C#";
            mail.Body = content;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(mail);
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}
