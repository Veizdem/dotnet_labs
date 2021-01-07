using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_013
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataTime = string.Format(
                "(d) - это формат \"короткой\" даты: . . . . . . . . . {0:d}\n" +
                "(D) - это формат \"полной\" даты: . . . . . . . . . . {0:D}\n" +
                "(t) - это формат \"короткого\" времени: . . . . . . . {0:t}\n" +
                "(T) - это формат \"длинного\" времени:. . . . . . . . {0:T}\n" +
                "(f) - выводится \"полная\" дата и \"короткое\" время: {0:f}\n" +
                "(F) - выводится \"полная\" дата и \"длинное\" время:. {0:F}\n" +
                "(g) General - короткая дата и короткое время: . . . . {0:g}\n" +
                "(G) General - \"общий\" формат: . . . . . . . . . . . {0:G}\n" +
                "Пустой формат - такой же, как формат (G): . . . . . . {0}\n" +
                "(M) - выводится только месяц и число: . . . . . . . . {0:M}\n" +
                "(U) Universal full date/time - время по Гринвичу: . . {0:U}\n" +
                "(Y) - по этому формату выводится только год:. . . . . {0:Y}\n",
                DateTime.Now);

            MessageBox.Show(dataTime, "Время и дата в различных форматах");

        }
    }
}
