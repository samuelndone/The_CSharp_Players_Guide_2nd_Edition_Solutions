// 3.a	Write a C# program to compute the sum of the first 500 prime numbers.

using System;
namespace week1
{
    class week1_3a
    {
        public static void Main()
        {
            long sum = 0;
            int testNumber = 2;
            for (int i = 0; i < 500; i++)
            {
                if (IsPrime(testNumber))
                {
                    sum = sum + testNumber;
                }
                else i--;
                testNumber++;
            }
            Console.WriteLine("Sum of the first 500 prime numbers is : " + sum);

        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}