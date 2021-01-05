using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Таблица";
            Console.Clear();

            Console.WriteLine("Число Корень");

            for (double i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,4} {1,8:F4}", i, Math.Sqrt(i));
            }

            Console.ReadKey();
        }
    }
}
