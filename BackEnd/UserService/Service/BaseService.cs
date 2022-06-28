
using Entity.Model;

namespace UserServiceAPI.Service
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
