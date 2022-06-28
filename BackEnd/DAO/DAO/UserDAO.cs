using Dapper;
using Entity.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace DAOProject.DAO
{
    public class UserDAO : DAO
    {
        public UserDAO() : base()
        {

        }

        public User GetUserByID(int userID)
        {
            var user = _dbConnection.QueryFirstOrDefault<User>($"Proc_GetUserByID", new { UserID = userID }, commandType: CommandType.StoredProcedure);
            return user;
        }

        public dynamic GetEmailHasDeadline(DateTime deadlineTime)
        {
            dynamic obj = new ExpandoObject();
            using(var multi = _dbConnection.QueryMultiple($"Proc_CheckDeadline", new { deadlineTime = deadlineTime }, commandType: CommandType.StoredProcedure))
            {
                obj.User = multi.Read<User>().AsList();
                obj.TodoItem = multi.Read<TodoItem>().AsList();
            }
            return obj;
        }

        public dynamic Login(string email)
        {
            dynamic obj = new ExpandoObject();
            using (var multi = _dbConnection.QueryMultiple($"Proc_Login", new { Email = email }, commandType: CommandType.StoredProcedure))
            {
                obj.TodoItem = multi.Read<TodoItem>().AsList();
                obj.UserID = multi.Read<int>();
            }
            return obj;
        }
    }
}
