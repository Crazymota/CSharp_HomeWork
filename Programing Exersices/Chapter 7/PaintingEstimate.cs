using System;
using static System.Console;
namespace PaintingEstimate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the room: ");
            double length = Convert.ToDouble(ReadLine());
            Console.Write("Please enter the width of the room: ");
            double width = Convert.ToDouble(ReadLine());

            double total = calculateTotalPrice(length, width);
            WriteLine("Your total price is $" + total);
        }

        private static double calculateTotalPrice(double length, double width)
        {
            double result = (length * length) + (width * width);
            result = result * 6;
            
            return  result;
        }
    }
}
