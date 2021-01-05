using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Складываю два числа";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Введите первое слагаемое");
            string @string = Console.ReadLine();

            float X = float.Parse(@string);

            Console.WriteLine("Введите первое слагаемое");
            @string = Console.ReadLine();

            float Y = float.Parse(@string);

            float Z = X + Y;

            Console.WriteLine("Сумма: {0} + {1} = {2}", X, Y, Z);
            Console.Beep(1000, 500);

            Console.ReadKey();
        }
    }
}
