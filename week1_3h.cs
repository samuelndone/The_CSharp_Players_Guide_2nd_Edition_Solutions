// 3.h	Write a program in C# Sharp to find the sum of first n natural numbers using recursion.

using System;
namespace week1
{
    class week1_3h
    {
        public static void Main()
        {
            Console.WriteLine("Program finds the sum of first N natural numbers.");
            Console.Write("Put value of N : ");

            string test = Console.ReadLine();
            int nr;
            while (!int.TryParse(test, out nr) || nr < 2)
            {
                Console.WriteLine("Input should be 2 or greater.Try again !");
                test = Console.ReadLine();
            }

            for (int i = 0; i < nr; i++)
            {
                string stringOfNumbers;

                if (i == nr - 1)
                {
                    stringOfNumbers = (i + 1) + " = ";
                }
                else
                {
                    stringOfNumbers = (i + 1) + " + ";
                }
                Console.Write(stringOfNumbers);
            }
            Console.WriteLine(SumRecursion(nr));
        }

        public static int SumRecursion(int numer)
        {
            if (numer == 1)
            { return 1; }
            else
            { return numer + SumRecursion(numer - 1); }
        }
    }
}
