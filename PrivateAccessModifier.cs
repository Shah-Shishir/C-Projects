/*** Ideone Link : https://ideone.com/l5mts7 ***/

using System;

namespace PrivateAccessModifier
{
    class Area
    {
        double b = 4.5, h = 3.5;

        double GetArea()
        {
            return 0.5 * b * h;
        }

        public void PrintArea()
        {
            Console.WriteLine("Base : {0}, Height : {1}, Area : {2}", b, h, GetArea());
        }
    }

    class Perform
    {
        static void Main(string[] args)
        {
            Area r = new Area();
            r.PrintArea();
        }
    }
}