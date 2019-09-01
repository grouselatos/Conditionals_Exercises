using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, l, w, b, h;
            double area = 0;
            Shape choice;

            Console.WriteLine("Input 1 for area of circle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of triangle");
            Console.Write("Input your choice : ");
            choice = (Shape)Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case Shape.Circle:
                    Console.Write("Input radius of the circle : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case Shape.Rectangle:
                    Console.Write("Input length  of the rectangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case Shape.Triangle:
                    Console.Write("Input the base of the triangle :");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = .5 * b * h;
                    break;
            }
            Console.Write($"The area is : {area}");
        }
    }
}
