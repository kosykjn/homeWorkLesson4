using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько у тебя денег?");
            int money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько стоит мороженое?");
            int icecreamCost = Convert.ToInt32(Console.ReadLine());

            int icecreamCount = 0;
            while(money >= icecreamCost)
            {
                money -= icecreamCost;
                icecreamCount++;
            }

            Console.WriteLine($"Сможешь купить {icecreamCount} морожен и останется {money} гривен");

            Console.ReadKey();
        }
    }
}
