using System;

namespace datetime
{
    class Program
    {
        static void Main (string[] args)
        {
            var date = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var yesterday = now.AddDays(-1);
            var tomorrow = now.AddDays(1);
            var Inityesterday = today.AddDays(-1);
            var Inittomorrow = today.AddDays(1);

            Console.WriteLine("Fixed Date : " + date);
            Console.WriteLine("Present Time : " + now);
            Console.WriteLine("Initial Time of today : " + today);
            Console.WriteLine("Yesterday : " + yesterday);
            Console.WriteLine("Initial Time of Yesterday : " + Inityesterday);
            Console.WriteLine("Tomorrow : " + tomorrow);
            Console.WriteLine("Initial Time of Tomorrow : " + Inittomorrow);
            Console.WriteLine("________ Some Variations ________");
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("dd-MM-yyyy"));
            Console.WriteLine(now.ToString("dd-MM-yyyy hh:mm"));
            Console.WriteLine(now.ToString("dd-MM-yyyy hh:mm:ss"));
        }
    }
}