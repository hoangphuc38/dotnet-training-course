// See https://aka.ms/new-console-template for more information


using BasicCSharp;

TemperatureConverter converter = new TemperatureConverter();

Console.WriteLine("Please select the convertor direction");
Console.WriteLine("1. From Celsius to Kevin.");
Console.WriteLine("2. From Kevin to Celsius.");
Console.Write("==> ");

string selection = Console.ReadLine();

double F, C = 0;

switch (selection)
{
    case "1":
        Console.Write("Please enter the Celsius temperature: ");
        F = converter.CelsiusToKevin(Console.ReadLine());
        Console.WriteLine("Temperature in Kevin: {0:F2}", F);
        break;
    case "2":
        Console.Write("Please enter the Fahrenheit temperature: ");
        C = converter.KevinToCelsius(Console.ReadLine());
        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
        break;
    default:
        Console.WriteLine("Please select a convertor.");
        break;
}

// Keep the console window open in debug mode.
Console.WriteLine("Press any key to exit.");
Console.ReadKey();