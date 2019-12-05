using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine($"{i} * {3} = {i * 3}");
            }

            Console.ReadKey();
        }
    }
}
