/*** Ideone Link : https://ideone.com/Yw3xpR ***/

using System;

namespace NullCoalescingOperator
{
    class Actual
    {
        static void Main(string[] args)
        {
            double? a = null;
            double? b = 3.14159;
            double? c;
            c = a ?? 5.34;
            Console.WriteLine("Nullable value, c = {0}", c);
            c = a ?? b;
            Console.WriteLine("Nullable value, c = {0}", c);
            c = b ?? 5.34;
            Console.WriteLine("Nullable value, c = {0}", c);
        }
    }
}