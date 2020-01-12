using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 3-ч значное число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cотни:" + a / 100);
            int b = Convert.ToInt32(a / 100);
            Console.WriteLine("десятки:" + (b * 100 - a) / 10 * -1);
            int c = Convert.ToInt32((b * 100 - a) / 10 * -1);
            Console.WriteLine("единицы:" + (a - b * 100 - c * 10));
            Console.ReadKey();
        }
    }
}
