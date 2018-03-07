/*** Ideone Link : https://ideone.com/ixWNZm ***/

using System;

namespace PublicAccessModifier
{
    class Area
    {
        public double b, h;

        public double GetArea()
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

            r.b = 4.5;
            r.h = 3.5;

            r.PrintArea();
        }
    }
}