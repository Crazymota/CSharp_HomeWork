using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string checker = Console.ReadLine(); 
            
            switch (checker) { 
                case "1":
                    Console.WriteLine(list);
                    break;
                case "2":
                    Array.Reverse(list);
                    Console.WriteLine(list);
                    break;
                case "3":
                    string find = Console.ReadLine();
                    int found = Array.BinarySearch(list, find);
                    Console.WriteLine(list);
                    break;
                default:
                    break;
            }

        }
    }
}
