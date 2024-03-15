using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current wind speed to determine the hurricane category");
            int hurricaneSpeed = Convert.ToInt32(Console.ReadLine());

            if (hurricaneSpeed >= 157)
                Console.WriteLine("This is a category 5 hurricane, RUN!!");
            else if (hurricaneSpeed < 157 && hurricaneSpeed >= 130)
                Console.WriteLine("This is a category 4 hurricane");
            else if (hurricaneSpeed < 130 && hurricaneSpeed >= 111)
                Console.WriteLine("This is a category 3 hurricane");
            else if (hurricaneSpeed < 111 && hurricaneSpeed >= 96)
                Console.WriteLine("This is a category 2 hurricane");
            else if (hurricaneSpeed < 96 && hurricaneSpeed >= 74)
                Console.WriteLine("This is a category 1 hurricane");
            else
                Console.WriteLine("This is not a a hurricane");

        }
    }
}
