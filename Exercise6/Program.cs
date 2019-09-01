using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Input the height of the person (in centimetres): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("The person is Dwarf.");
            else if (height <= 165)
                Console.WriteLine("The person is average heighted.");
            else if (height <= 195)
                Console.WriteLine("The person is taller.");
            else
                Console.WriteLine("Abnormal height.");
        }
    }
}
