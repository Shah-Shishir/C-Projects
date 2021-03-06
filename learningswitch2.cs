﻿/*** Ideone Link : https://ideone.com/eCKCTw ***/

using System;

namespace learningswitch2
{
    class Switch
    {
        public static void Main(string[] args)
        {
            int a = 80;

            switch (a)
            {
                case 10:
                    Console.WriteLine("A = 10");
                    break;

                case 20:
                    Console.WriteLine("A = 20");
                    break;

                case 30:
                    Console.WriteLine("A = 30");
                    break;

                case 40:
                    Console.WriteLine("A = 40");
                    break;

                case 50:
                    Console.WriteLine("A = 50");
                    break;

                default:
                    Console.WriteLine("A = 80");
                    break;
            }

            Console.WriteLine("Actual value of A is 80.");
        }
    }
}