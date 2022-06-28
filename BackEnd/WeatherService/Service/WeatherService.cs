
using DAOProject.DAO;
using Entity.Enum;
using Entity.Model;

namespace WeatherServiceAPI.Service
{
    public class WeatherService : BaseService
    {
        WeatherDAO _weatherDAO = null;
        public WeatherService() : base()
        {
            _weatherDAO = new WeatherDAO();
        }

        public ServiceResult GetWeather(string place)
        {
            Weather result = _weatherDAO.GetWeather(place);
            if (result.Equals(""))
            {
                _serviceResult.Data = result;
                _serviceResult.ResponseCode = ResponseCode.BadRequest;
                _serviceResult.Messenger = "Không tìm thấy";
            }
            _serviceResult.Data = result;
            _serviceResult.ResponseCode = ResponseCode.Success;
            _serviceResult.Messenger = "Thành công";
            return _serviceResult;
        }
    }
}
