using Dapper;
using Entity.Model;
using System.Collections.Generic;
using System.Data;

namespace DAOProject.DAO
{
    public class TodoDAO : DAO
    {
        public TodoDAO() : base()
        {

        }
        public List<TodoItem> GetTodoItemList(int userID)
        {
            var itemList = _dbConnection.Query<TodoItem>("Proc_GetAllTodoItem", new { UserID = userID }, commandType: CommandType.StoredProcedure).AsList();

            return itemList;
        }
        public List<TodoItem> AddTodoItem(TodoItem todoItem)
        {
            var itemList = _dbConnection.Query<TodoItem>("Proc_AddTodoItem", new
            {
                userID = todoItem.UserID,
                title = todoItem.Title,
                deadlineTime = todoItem.DeadlineTime,
                description = todoItem.Description,
                place = todoItem.Place,
            }, commandType: CommandType.StoredProcedure).AsList();

            return itemList;
        }


    }
}
