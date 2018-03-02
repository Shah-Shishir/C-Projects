/*** Ideone Link : learningswitch3 ***/

using System;

namespace learningswitch3
{
    class Switch
    {
        public static void Main(string[] args)
        {
            int a = 100, b = 200;

            switch (a)
            {
                case 50:
                    {
                        Console.WriteLine("a = 50");

                        switch (b)
                        {
                            case 200:
                                Console.WriteLine("b = 200");
                                break;
                        }
                    }
                    break;

                case 100:
                    {
                        Console.WriteLine("a = 100");

                        switch (b)
                        {
                            case 200:
                                Console.WriteLine("b = 200");
                                break;
                        }
                    }
                    break;
            }

            Console.WriteLine("Actual value of a is {0}\nActual value of b is {1}", a, b);
        }
    }
}