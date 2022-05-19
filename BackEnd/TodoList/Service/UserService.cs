using TodoList.DAO;
using TodoList.Entity;

namespace TodoList.Service
{
    public class UserService : BaseService
    {
        private UserDAO _userDAO;
        public UserService() : base()
        {
            _userDAO = new UserDAO();
        }
        public ServiceResult GetUserByID(int userID)
        {
            var result = _userDAO.GetUserByID(userID);
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

        public ServiceResult Login(string email)
        {
            var result = _userDAO.Login(email);
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
    }
}
