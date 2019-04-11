using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in Farenheit: ");
            double temperatureInFarenheit = double.Parse(Console.ReadLine());

            Console.WriteLine($"Temperature in Farenheit - {temperatureInFarenheit}, in Celsius ={ConvertTemperatureToCelsius(temperatureInFarenheit)}");

            Console.ReadKey(true);
        }

        static double ConvertTemperatureToCelsius(double temperatureInFarenheit)
        {
            return (temperatureInFarenheit - 32) * 5 / 9.0;
        }
    }
}
