using System;

namespace homeWorkLesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for loop

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region while loop

            int number1 = 0;
            
            while (number1 < 5)
            {
                Console.WriteLine(++number1);
            }

            Console.WriteLine("**********");

            #endregion

            #region do while loop

            int number2 = 0;

            do
            {
                Console.WriteLine(++number2);
            } 
            while (number2 < 5);

            Console.WriteLine("**********");

            #endregion

            Console.ReadKey();
        }
    }
}
