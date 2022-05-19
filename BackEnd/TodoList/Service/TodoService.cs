using TodoList.DAO;
using TodoList.Entity;

namespace TodoList.Service
{
    public class TodoService : BaseService
    {
        TodoDAO _todoDAO = null;
        public TodoService() : base()
        {
            _todoDAO = new TodoDAO();
        }

        public ServiceResult GetTodoItemList(int userID)
        {
            var result = _todoDAO.GetTodoItemList(userID);
            if (result == null)
            {
                _serviceResult.Data = result;
                _serviceResult.ResponseCode = Enum.ResponseCode.BadRequest;
                _serviceResult.Messenger = "Không tìm thấy";
            }
            _serviceResult.Data = result;
            _serviceResult.ResponseCode = Enum.ResponseCode.Success;
            _serviceResult.Messenger = "Thành công";
            return _serviceResult;
        }

        public ServiceResult AddTodoItem(TodoItem todoItem)
        {
            var result = _todoDAO.AddTodoItem(todoItem);
            if(result.Count == 0)
            {
                _serviceResult.Data = result;
                _serviceResult.ResponseCode = Enum.ResponseCode.BadRequest;
                _serviceResult.Messenger = "Không tìm thấy";
            }
            _serviceResult.Data = result;
            _serviceResult.ResponseCode = Enum.ResponseCode.Success;
            _serviceResult.Messenger = "Thành công";
            return _serviceResult;
        }
    }
}
