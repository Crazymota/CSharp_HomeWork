using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    XXXXXXX ");
            Console.WriteLine("  XX       XX");
            Console.WriteLine("XX   STOP    XX");
            Console.WriteLine("  XX       XX");
            Console.WriteLine("    XXXXXXX ");
            for (int i = 0; i < 10; i++) { Console.WriteLine("       X "); }
        }
    }
}
