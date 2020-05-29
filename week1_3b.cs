// 3.b	Write a C# program to reverse the words of a sentence.

using System;
namespace week1
{
    class week1_3b
    {
        public static void Main()
        {
            Console.WriteLine("Type the sentence :");
            string sentence = Console.ReadLine();
            Console.WriteLine(Reverse(sentence));
        }

        public static string Reverse(string sentence)
        {
            int nrChar = sentence.Length;
            char[] chars = new char[nrChar];

            for (int i = 0; i < nrChar; i++)
            {
                chars[i] = sentence[i];
            }

            string reversed = "";

            for (int j = chars.Length - 1; j >= 0; j--)
            {
                reversed = reversed + chars[j].ToString();
            }
            return reversed;
        }
    }
}