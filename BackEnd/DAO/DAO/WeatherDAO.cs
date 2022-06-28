using Entity.Model;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace DAOProject.DAO
{ 
    public class WeatherDAO
    {
        private const string APP_ID = "ae497c21770b3e551b456f3ab0033f53";
        private string URL = $"https://api.openweathermap.org/data/2.5/weather?q=";
        private string urlParameters = $"&appid={APP_ID}&units=metric&lang=vi";

        public WeatherDAO()
        {
            
        }

        public Weather GetWeather(string place)
        {
            string result = "";
            string UrlFull = URL+ place + urlParameters;
            WebRequest request = WebRequest.Create(UrlFull);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(stream);
                result = streamReader.ReadToEnd();
            }
            dynamic test = JsonConvert.DeserializeObject(result);
            Weather weather = new Weather();
            weather.Description = test.weather[0].description;
            weather.Temp = test.main.temp;
            weather.CityName = test.name;
            weather.Humidity = test.main.humidity;
            if(weather.Humidity > 80)
            {
                weather.Suggest = "Trời có thể mưa";
            }
            return weather;
        }   
    }
}
