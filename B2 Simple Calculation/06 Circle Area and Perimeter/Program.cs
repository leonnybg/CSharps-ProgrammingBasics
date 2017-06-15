using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area=" + Math.PI * radius * radius);
            Console.WriteLine("Perimeter=" + 2 * Math.PI * radius);
        }
    }
}
