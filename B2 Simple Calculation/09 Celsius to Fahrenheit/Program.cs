using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradiusCelsius = double.Parse(Console.ReadLine());
            var gradiusFahrenheit = (gradiusCelsius * 9 / 5) + 32;
            Console.WriteLine(gradiusFahrenheit);
        }
    }
}
