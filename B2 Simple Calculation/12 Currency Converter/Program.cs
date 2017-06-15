using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = decimal.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            var text2 = Console.ReadLine();
            decimal suma1 = 0.0m;
            if (text == "BGN")
            {
                if (text2 == "USD")
                {
                    suma1 = suma * 1.79549m;
                }
                else if (text2 == "EUR")
                {
                    suma1 = suma / 1.95583m;
                }
                else if (text2 == "GBP")
                {
                    suma1 = suma * 2.53405m;
                }
            }
            else if (text == "USD")
            {
                if (text2 == "BGN")
                {
                    suma1 = suma * 1.79549m;
                }
                else if (text2 == "EUR")
                {
                    suma1 = suma * (1.79549m / 1.95583m);
                }
                else if (text2 == "GBP")
                {
                    suma1 = suma * (1.79549m / 2.53405m);
                }
            }
            else if (text == "EUR")
            {
                if (text2 == "BGN")
                {
                    suma1 = suma / 1.95583m;
                }
                else if (text2 == "USD")
                {
                    suma1 = suma * (1.95583m / 1.79549m);
                }
                else if (text2 == "GBP")
                {
                    suma1 = suma * (1.95583m / 2.53405m);
                }

            }
            else if (text == "GBP")
            {
                if (text2 == "BGN")
                {
                    suma1 = suma * (2.53405m / 1m);
                }
                else if (text2 == "USD")
                {
                    suma1 = suma * (2.53405m / 1.79549m);
                }
                else if (text2 == "EUR")
                {
                    suma1 = suma * (2.53405m / 1.95583m);
                }
            }
            Console.WriteLine(Math.Round(suma1, 2) + " {0}", text2);
        }
    }
}
