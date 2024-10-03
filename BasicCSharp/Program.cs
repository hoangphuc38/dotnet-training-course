// See https://aka.ms/new-console-template for more information

using BasicCSharp.FindEvenNumber;
using BasicCSharp.TemperatureConverter;
using BasicCSharp.TransferText;

//Program that solves problem of converting between Celsius and Kevin
ConvertProgram convertProgram = new ConvertProgram();
convertProgram.Main();

Console.WriteLine();
Console.WriteLine("--------------------------------------\n");

//Program that solves problem of finding even number in an array
EvenNumberProgram evenNumberProgram = new EvenNumberProgram();
evenNumberProgram.Main();

Console.WriteLine("--------------------------------------\n");

//Program that solve of problem of transferring a string between being upper and being lower
TransferTextProgram transferTextProgram = new TransferTextProgram();
transferTextProgram.Main();

