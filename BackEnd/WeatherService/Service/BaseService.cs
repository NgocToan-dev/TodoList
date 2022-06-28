
using Entity.Model;

namespace WeatherServiceAPI.Service
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
