using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"{num} = 0");
            }
            else
            {
                Console.WriteLine($"{num} is a negative number.");
            }
        }
    }
}
