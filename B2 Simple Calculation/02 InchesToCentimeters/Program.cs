using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            // 1 Inch= 2.54 cm
            var centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
