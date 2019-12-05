using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson4_10
{
    class Program
    {
        static void Main(string[] args)
        { 

            while (true)
            {
                Start:
                    Console.WriteLine("Введите первое число:");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите знак арифметической операции:");
                    string znak = Console.ReadLine();

                    switch (znak)
                    {
                        case "+":
                            Console.WriteLine(number1 + number2); goto Start;
                        case "-":
                            Console.WriteLine(number1 - number2); goto Start;
                        case "*":
                            Console.WriteLine(number1 * number2); goto Start;
                        case "/":
                            if (number2 == 0)
                            {
                                Console.WriteLine("Простите на 0 делить нельзя!"); 
                                goto Start;
                            }
                            Console.WriteLine(number1 / number2); goto Start;
                        case "0":
                            Console.WriteLine("Спасибо!"); goto End;
                        default:
                            Console.WriteLine("Нет такого арифметического знака!");
                            goto Start;
                    }
                End:
                    break;
            }
            Console.ReadKey();
        }
    }
}
