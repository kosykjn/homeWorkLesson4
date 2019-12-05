using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Равнобедренный треугольник
            int triangleRowCount = 5; //кол-во рядов

            int triangleRowStarsCount = 1;
            for (int i = 0; i < triangleRowCount; i++)
            {
                Console.WriteLine($"{new string(' ', triangleRowCount - 1 - i)}{new string('*', triangleRowStarsCount)}");
                triangleRowStarsCount += 2;
            }

            Console.WriteLine(new string('-', 10));

            //Ромб
            int rombRowCount = 10; //кол-во рядов
            int rombRowStarsCount = 1;
            int spaceCount = (rombRowCount / 2) - 1;
            for (int i = 0; i < rombRowCount - 1; i++)
            {
                Console.WriteLine($"{new string(' ', spaceCount)}{new string('*', rombRowStarsCount)}");
                
                if (i >= (rombRowCount / 2) - 1)
                {
                    rombRowStarsCount -= 2;
                    spaceCount++;
                }
                else
                {
                    rombRowStarsCount += 2;
                    spaceCount--;
                }
            }

            Console.WriteLine(new string('-', 10));

            //Прямоугольник
            int width = 5;
            int height = 4;

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine($"{new string('*', width)}");
            }

            Console.ReadKey();
        }
    }
}
