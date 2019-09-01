using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Input the  value of m : ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                n = 1;
            }
            else if (m < 0)
            {
                n = -1;
            }
            else
            {
                n = 0;
            }

            //if (m != 0)
            //{
            //    if (m > 0)
            //    {
            //        n = 1;
            //    }
            //    else
            //    {
            //        n = -1;
            //    }
            //}
            //else
            //{
            //    n = 0;
            //}

            Console.WriteLine($"The value of m = {m}");
            Console.WriteLine($"The value of n = {n}");
        }
    }
}
