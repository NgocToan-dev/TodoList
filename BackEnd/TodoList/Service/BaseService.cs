using TodoList.Entity;

namespace TodoList.Service
{
    public class BaseService
    {
        protected ServiceResult _serviceResult = null;
        
        public BaseService()
        {
            _serviceResult = new ServiceResult();
        }
    }
}
