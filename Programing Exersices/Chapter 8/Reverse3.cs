using System;
using static System.Console;

namespace Reverse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 1;
            int middleInt = 2;
            int lastInt = 3;

            WriteLine("Values in correct order " + firstInt + " " + middleInt + " " + lastInt);
            reversed(ref firstInt,ref lastInt);
            WriteLine("Values in reversed order " + firstInt + " " + middleInt + " " + lastInt);
        }
        static int reversed(ref int firstInt,ref int lastInt)
        {
            int temp = 0;

            temp = lastInt;
            lastInt = firstInt;
            firstInt = temp;


            return firstInt + lastInt;
        }

    }
}
