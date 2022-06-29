using DAOProject.DAO;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace WeatherServiceAPI.Service
{
    public class NotificationEmailService
    {
        private UserDAO userDAO = new UserDAO();
        private WeatherDAO weatherDAO = new WeatherDAO();   
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

                        content = $"Hiện tại có những việc cần phải hoàn thành sau đây :\n";
                        bool isBuildDone = false;
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            if (todoList[i].UserID.Equals(u.UserID))
                            {
                                content += $"Công việc {i + 1}\n\t";
                                content += todoList[i].Title + "\n\t" + todoList[i].Description + "\n\tĐịa điểm: "+todoList[i].Place +"\n";
                                if(todoList[i].Place.Length > 0)
                                {
                                    Weather weather = weatherDAO.GetWeather(todoList[i].Place);
                                    content += $"\tThời tiết tại {weather.CityName} hiện tại {weather.Description}, nhiệt đô {weather.Temp}, độ ẩm {weather.Humidity}.{weather.Suggest}\n\n";
                                }
                            }
                            if (i == todoList.Count - 1)
                            {
                                isBuildDone = true;
                            }
                        }
                        if (isBuildDone)
                        {
                            from = "testsendemail111@gmail.com";
                            pass = "elilhsehnsexvyps";
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
                            smtp.UseDefaultCredentials = false;
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
