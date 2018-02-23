using System;

namespace DefiningConstants
{
    public class Const
    {
        public static void Main()
        {
            const double pi = 3.14159;
            double r, A;

            Console.Write("Enter the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            A = pi * r * r;

            Console.WriteLine("Radius : {0}, Area = {1}", r, A);
        }
    }
}