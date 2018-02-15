using System;

namespace RectangleApplication
{
    class MyRectangle
    {
        double length;
        double width;

        public void Acceptdetails ()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea ()
        {
            return length * width;
        }

        public void Print ()
        {
            Console.WriteLine("Length : {0}",length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main (string[] args)
        {
            MyRectangle r = new MyRectangle();

            r.Acceptdetails ();
            r.Print ();
        }
    }
}