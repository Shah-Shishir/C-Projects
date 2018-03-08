/*** Ideone Link : https://ideone.com/1jsOfw ***/

using System;

namespace NullablesIntro
{
    class Actual
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = 12;
            int? c = new int?();
            double? d = new double?();
            bool? e = new bool?();

            Console.WriteLine("Nullable values\na = {0}, b = {1}, c = {2}, d = {3}, e = {4}", a, b, c, d, e);
        }
    }
}