using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите желаемую сумму вклада:");
            double summ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите желаемую процентную ставку:");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок на который желаете сделать вклад:");
            double depositТerm = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < depositТerm; i++)
            {
               double depositPercent = summ * percent / 100;
               summ += depositPercent;
            }

            Console.WriteLine($"Ваша выплата по окончанию срока вклада {summ} за {depositТerm} лет");

            Console.ReadKey();
        }
    }
}
