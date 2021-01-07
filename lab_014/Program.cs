using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_014
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string;

            for (; ; )
            {
                @string = Microsoft.VisualBasic.Interaction.InputBox("Введите первое число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.IsNumeric(@string) == true)
                    break;
            }

            float X = float.Parse(@string);

            for (; ; )
            {
                @string = Microsoft.VisualBasic.Interaction.InputBox("Введите второе число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.IsNumeric(@string) == true)
                    break;
            }

            float Y = float.Parse(@string);

            float Z = X + Y;

            @string = string.Format("Сумма: {0} + {1} = {2}", X, Y, Z);

            Microsoft.VisualBasic.Interaction.MsgBox(@string);

        }
    }
}
