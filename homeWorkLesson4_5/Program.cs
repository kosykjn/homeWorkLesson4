using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 1; i < number; i++)
            {
                result += i;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
