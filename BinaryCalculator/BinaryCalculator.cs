using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = Console.ReadLine(); 
            string value2 = Console.ReadLine();
            string operation = Console.ReadLine();

            int opValue1 = Convert.ToInt32(value1);
            int opValue2 = Convert.ToInt32(value2);
            var result = doWork(opValue1,opValue2, operation);
            
            Console.WriteLine(result);

        }
        static int doWork(int opValue1, int opValue2, string operation)
        {
            var result = 0;
            switch (operation)
            {
                case "AND":
                    result = opValue1 & opValue2;
                    break;
                case "OR":
                    result = opValue1 | opValue2;
                    break;
                case "XOR":
                    result = opValue1 ^ opValue2;
                    break;
                case "NOT":
                    result = ~opValue1;
                    break;
                default:
                    Console.WriteLine("Not work");
                    break;
            }
            return result;
        }
        
    }


 }

