using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day;


            Console.Write("Input Day Number: ");
            day = (Day)Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case Day.Monday:
                    Console.WriteLine("Monday");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case Day.Friday:
                    Console.WriteLine("Friday");
                    break;
                case Day.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                case Day.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
