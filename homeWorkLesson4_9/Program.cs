using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());

            int summ = 0;
            if (A > B)
            {
                Console.WriteLine($"{A} больше {B}");

                for (int i = B + 1; i < A; i++)
                {
                    summ += i;
                }
                Console.WriteLine($"Сумма чисел находящихся между {A} и {B} = {summ}");
            }
            else 
            {
                for (int j = A+1; j < B; j++)
                { 
                    if (j % 2 !=0)
                    {
                        summ += j;
                    }
                }
                Console.WriteLine($"Сумма всех нечетных чисел между {A} и {B} = {summ}");
            }
            Console.ReadKey();
        }
    }
}
