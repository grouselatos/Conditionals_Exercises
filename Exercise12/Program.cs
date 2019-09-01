using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Option opt;

            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nHere are the options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = (Option)Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case Option.Addition:
                    Console.Write($"The Addition of  {num1} and {num2} is: {num1 + num2}");
                    break;

                case Option.Substraction:
                    Console.WriteLine($"The Substraction of {num1}  and {num2} is: {num1 - num2}");
                    break;

                case Option.Multiplication:
                    Console.WriteLine($"The Multiplication of {num1}  and {num2} is: {num1 * num2}");
                    break;

                case Option.Division:
                    if (num2 == 0)
                    {
                        Console.WriteLine("The second integer is zero. Devide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"The Division of {num1}  and {num2} is : {num1 / num2}");
                    }
                    break;

                case Option.Exit:
                    break;

                default:
                    Console.WriteLine("Input correct option");
                    break;
            }
        }
    }
}
