using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using TodoList.DAO;
using TodoList.Entity;

namespace TodoList.Service
{
    public class NotificationEmailService
    {
        private UserDAO userDAO = new UserDAO();
        public NotificationEmailService()
        {

        }
        public void sendEmailRemind()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer((e) =>
            {
                dynamic obj = userDAO.GetEmailHasDeadline(DateTime.Now);
                List<User> userList = obj.User;
                List<TodoItem> todoList = obj.TodoItem;
                
                if(todoList.Count > 0)
                {
                    foreach (User u in userList)
                    {
                        string from, to, pass, content = "";

                        content = $"Hiện tại có những việc cần phải hoàn thành sau đây {userList.Count}:\n";
                        bool isBuildDone = false;
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            if (todoList[i].UserID.Equals(u.UserID))
                            {
                                content += todoList[i].Title + "\n" + todoList[i].Description + "\n";
                            }
                            if (i == todoList.Count - 1)
                            {
                                isBuildDone = true;
                            }
                        }
                        if (isBuildDone)
                        {
                            from = "testsendemail111@gmail.com";
                            pass = "Toan@123456";
                            to = u.Email;

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress(from);
                            mail.To.Add(to);
                            mail.Subject = "Thông báo việc cần hoàn thành";
                            mail.Body = content;

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);
                            try
                            {
                                smtp.Send(mail);
                            }
                            catch (Exception ex)
                            {
                                throw;
                            }
                        }
                    }
                }

            }, null, startTimeSpan, periodTimeSpan);

        }
    }
}
