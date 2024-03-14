using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRaisesInteractive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double raise = 4.0;
            double employee1 = 5000.0;
            double employee2 = 6000.0;
            double employee3 = 7000.0;

            employee1 = (employee1 / raise) + employee1;
            employee2 = (employee2 / raise) + employee2;
            employee3 = (employee3 / raise) + employee3; 
             
            Console.WriteLine("Your current salary will be " + employee1);
            Console.WriteLine("Your current salary will be " + employee2);
            Console.WriteLine("Your current salary will be " + employee3);

        }
    }
}
