using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace NEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("");
        }
        public static void Print(string input)
        {

            Thread.Sleep(15);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
    }
}
