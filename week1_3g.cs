// 3.g	Write a program in C# Sharp to print all unique elements in an array.

using System;
namespace week1
{
    class week1_3g
    {
        public static void Main()
        {
            Console.Write("Number of vector elements = ");
            string test = Console.ReadLine();
            int nrElements;
            while (!Int32.TryParse(test, out nrElements) || nrElements < 1)
            {
                Console.WriteLine("Input should be a positive number.Try again !");
                test = Console.ReadLine();
            }

            int[] vector = new int[nrElements];

            for (int i = 0; i < nrElements; i++)
            {
                Console.Write("Element {0} = ", i + 1);
                string testV = Console.ReadLine();
                int elementV;
                while (!Int32.TryParse(testV, out elementV))
                {
                    Console.WriteLine("Input should be number.Try again !");
                    testV = Console.ReadLine();
                }
                vector[i] = elementV;
            }
            Console.WriteLine("Vector full !");

            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < nrElements; i++)
            {
                for (int j = 0; j < nrElements; j++)
                {
                    if (vector[i] == vector[j] && i != j)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("Element " + vector[i] + " is unique in vector.");
                    counter2++;
                }
                else counter = 0;
            }

            if (counter2 == 0)
            {
                Console.WriteLine("None unique element found in this vector !");
            }
        }
    }
}