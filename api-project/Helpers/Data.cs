using System.Collections.Generic;

namespace api_proyect.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }

        public string name;
        public int value;
        public bool isChecked;
        public List<int> numbers = new List<int>();
        public List<WeatherForecast> weatherForecasts = new List<WeatherForecast>();
    }
}
