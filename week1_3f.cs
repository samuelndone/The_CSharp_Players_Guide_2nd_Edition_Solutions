// 3.f	Write a C# Sharp program to calculate the factorial of a given number.

using System;
namespace week1
{
    class week1_3f
    {
        public static void Main()
        {
            Console.Write("Number = ");
            string test = Console.ReadLine();
            int nr;
            while (!int.TryParse(test, out nr) || nr < 1)
            {
                Console.WriteLine("Input should be positive number.Try again !");
                test = Console.ReadLine();
            }
            Console.WriteLine("Factorial of " + nr + " is " + Factorial(nr));
        }

        public static long Factorial(int numer)
        {
            return numer == 0 ? 1 : numer * Factorial(numer - 1);
            /*
              if (numer == 0)
               { return 1; }
              else return numer * Factorial(numer - 1);
            */
        }
    }
}
