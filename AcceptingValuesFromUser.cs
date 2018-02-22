/// Ideone Link : https://ideone.com/lC89I9

using System;

namespace AcceptingValuesFromUser
{
    public class Consol
    {
        public static void Main()
        {
            int a, b;
            double c, d;
            char e, f;
            string g, h;

            Console.WriteLine("Enter two integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a + b = {0}", a + b);

            Console.WriteLine("Enter two real numbers");
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c/3 + b/3 = {0}", c / 3 + b / 3);

            Console.WriteLine("Enter two characters");
            e = Convert.ToChar(Console.ReadLine());
            f = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("e + f = {0}", e + f);

            Console.WriteLine("Enter two strings");
            g = Convert.ToString(Console.ReadLine());
            h = Convert.ToString(Console.ReadLine());
            Console.WriteLine("g + h = {0}", g + h);
        }
    }
}