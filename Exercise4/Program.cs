using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            // if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }

            Console.ReadLine();
        }
    }
}