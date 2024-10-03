using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp.TemperatureConverter
{
    public class ConvertProgram
    {
        private TemperatureConverter _converter = new TemperatureConverter();

        public void Main()
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Kevin.");
            Console.WriteLine("2. From Kevin to Celsius.");
            Console.Write("==> ");

            //Check if selection is null, empty or out of range [1, 2]
            string selection = Console.ReadLine();
            while (string.IsNullOrEmpty(selection) || Convert.ToInt32(selection) > 2)
            {
                Console.Write("Please select a convertor: ");
                selection = Console.ReadLine();
            }

            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    F = _converter.CelsiusToKevin(Console.ReadLine());
                    Console.WriteLine("Temperature in Kevin: {0:F2}", F);
                    break;
                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    C = _converter.KevinToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;
            }
        }
    }
}
