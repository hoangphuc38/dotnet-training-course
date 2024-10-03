using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.TemperatureConverter
{
    public class TemperatureConverter
    {
        /// <summary>
        /// Convert user's input of Celsius degree to Kevin degree
        /// </summary>
        /// <param name="temperatureCelsius">temperatureCelsius</param>
        /// <returns>After calculating Kevin degree, return Kevin degree in Double format</returns>
        public double CelsiusToKevin(string temperatureCelsius)
        {
            double celsius = double.Parse(temperatureCelsius);

            double kevin = celsius + 273.15;

            return kevin;
        }

        /// <summary>
        /// Convert user's input of Kevin degree to Celsius degree
        /// </summary>
        /// <param name="temperatureKevin">temperatureKevin</param>
        /// <returns>After calculating Celcius degree, return Celsius degree in Double format</returns>
        public double KevinToCelsius(string temperatureKevin)
        {
            double kevin = double.Parse(temperatureKevin);

            double celsius = kevin - 273.15;

            return celsius;
        }
    }
}
