using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibanachi1 = 0;
            int fibanachi2 = 1;

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******");

            for (int i = 1; i <= number; i++)
            {
                int fibanachiSumm = fibanachi1 + fibanachi2;
                fibanachi1 = fibanachi2;
                fibanachi2 = fibanachiSumm;
                Console.WriteLine(fibanachi2);
            }

            Console.ReadKey();
        }
    }
}
