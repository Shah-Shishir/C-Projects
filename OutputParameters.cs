/*** 

	The difference between Reference Parameters and Output Parameters in my perspective is -> 
For Reference Parameters, the value needs to be assigned into the variable, but For Output Parameters, 
it doesn't.

    Ideone Link : https://ideone.com/5nZ8fa

***/

using System;

namespace OutputParameters
{
    class Secondary
    {
        public void Scanner(out int a, out int b)
        {
            Console.Write("Enter the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Primary
    {
        static void Main(string[] args)
        {
            int a, b;

            Secondary r = new Secondary();
            r.Scanner(out a, out b);

            Console.WriteLine("Value of a : {0}, Value of b : {1}", a, b);
        }
    }
}