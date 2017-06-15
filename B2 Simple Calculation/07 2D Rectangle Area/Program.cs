using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double widht = Math.Max(x1, x2) - Math.Min(x1, x2);
            double hight = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(widht * hight);
            Console.WriteLine(2 * (widht + hight));
        }
    }
}
