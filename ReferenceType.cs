/// Ideone Link : https://ideone.com/ZaGn8J

using System;

namespace ReferenceType
{
    public class ReferenceExample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("__________ Reference Type __________");

            Console.WriteLine("___ Object Type ___");
            object obj = 20; /// Boxing
	    Console.WriteLine(obj); /// Type-checking occurs at compile time
            int x = (int)(obj); /// Unboxing
            Console.WriteLine("After Unboxing : {0}", x);
            obj = 2.34;
            Console.WriteLine(obj);
            obj = 'x';
            Console.WriteLine(obj);
            obj = "Love";
            Console.WriteLine(obj);

            Console.WriteLine("___ Dynamic Type ___");
            dynamic d = 20; /// Type-checking occurs at run time
	    Console.WriteLine(d);
            d = 5.7798;
            Console.WriteLine(d);
            d = 'u';
            Console.WriteLine(d);
            d = "Commitment";
            Console.WriteLine(d);

            Console.WriteLine("___ String Type ___");
            string str = "C-sharp == Love";
            Console.WriteLine(str);
            str = "C-sharp == Love\n";
            Console.WriteLine(str);
            str = @"C-sharp == Love";
            Console.WriteLine(str);
        }
    }
}