using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1000Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateString = Console.ReadLine();
            var date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
