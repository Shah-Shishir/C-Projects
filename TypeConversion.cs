/// Ideone Link : https://ideone.com/kU8rfG

using System;

namespace TypeConversion
{
    public class ConverThem
    {
        public static void Main(string[] args)
        {
            /// Explicit conversion

            double d = 56.6787;
            int i = (int)d;
            Console.WriteLine(i);

            /// Conversion to String

            float f = 12.0001f;
            Single s = 13.41f;
            Decimal x = 4.5m;
            char c = 'R';
            bool b = true;

            Console.WriteLine(d.ToString());
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine(x.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}