// 3.d Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

using System;
namespace week1
{
    class week1_3d
    {
        public static void Main()
        {
            Console.Write("Decimal number : ");
            string decimalTest = Console.ReadLine();
            int nrDecimal;
            while (!int.TryParse(decimalTest, out nrDecimal) || nrDecimal < 1)
            {
                Console.WriteLine("Input should be positive number.Try again !");
                decimalTest = Console.ReadLine();
            }

            string binary = "";
            int residue;

            for (; nrDecimal > 1; nrDecimal /= 2)
            {
                residue = nrDecimal % 2;
                binary = Convert.ToString(residue) + binary;
            }
            binary = Convert.ToString(nrDecimal) + binary;
            Console.WriteLine("Binary form : " + binary);
        }
    }
}
