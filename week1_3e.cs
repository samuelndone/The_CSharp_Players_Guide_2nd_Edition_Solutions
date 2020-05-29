// 3.e	Write a program in C# Sharp to read any day number in integer and display day name in the word.

using System;
namespace week1
{
    class week1_3e
    {
        public static void Main()
        {
            Console.WriteLine("Day's number :");

            string test = Console.ReadLine();
            int daysNumber;
            while (!int.TryParse(test, out daysNumber) || daysNumber < 1 || daysNumber > 7)
            {
                Console.WriteLine("Input should be a number from 1 to 7.Try again !");
                test = Console.ReadLine();
            }

            switch (daysNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
