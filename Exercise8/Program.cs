using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double physics, chemistry, computerApplications, total = 0;
            double percentage;
            string name;
            bool pass = false;

            Console.Write("Input the Name of the Student: ");
            name = Console.ReadLine();

            Console.Write("Input  the marks of Physics: ");
            physics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry: ");
            chemistry = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application: ");
            computerApplications = Convert.ToDouble(Console.ReadLine());

            total = physics + chemistry + computerApplications;
            percentage = total / 3.0;

            if (percentage > 65)
            {
                pass = true;
            }

            Console.WriteLine($"Name of Student : {name}");
            Console.WriteLine($"Marks in Physics : {physics}\nMarks in Chemistry : {chemistry}\nMarks in Computer Application : {computerApplications}");
            Console.WriteLine($"Total Marks = {total}\nPercentage = {percentage}\nPass = {pass}");
        }
    }
}
