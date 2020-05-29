// 3.c	Write a C# program to check if an array contains an odd number.

using System;
namespace week1
{
    class week1_3c
    {
        public static void Main()
        {
            Console.WriteLine("Number of vector's elements : ");
            string test = Console.ReadLine();
            int nrElement;

            while (!int.TryParse(test, out nrElement) || nrElement < 1)
            {
                Console.WriteLine("Input should be positive number.Try again !");
                test = Console.ReadLine();
            }

            int[] vector = new int[nrElement];

            for (int i = 0; i < nrElement; i++)
            {
                Console.Write("Element {0} = ", i + 1);
                string testV = Console.ReadLine();
                int elementV;
                while (!int.TryParse(testV, out elementV))
                {
                    Console.WriteLine("Input should be number.Try again !");
                    testV = Console.ReadLine();
                }
                vector[i] = elementV;
            }

            int counter = 0;
            for (int j = 0; j < nrElement; j++)
            {
                if (IsOdd(vector[j]))
                {
                    Console.WriteLine("Odd number found : " + vector[j]);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Vector doesn't contain any odd number.");
            }
        }
        private static bool IsOdd(int nr)
        {
            if (nr % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
