using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;
            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = int.Parse(Console.ReadLine());

            if (int1 == int2)
            {
                Console.WriteLine($"{int1} and {int2} are equal.");
            }
            else
            {
                Console.WriteLine($"{int1} and {int2} are not equal.\n");
            }

            // Ternary operator
            //string message = int1 == int2 
            //                 ? $"{int1} and {int2} are equal." 
            //                 : $"{int1} and {int2} are not equal.\n";
            //Console.WriteLine(message);
        }
    }
}
