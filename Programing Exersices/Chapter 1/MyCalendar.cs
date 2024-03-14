using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int month;
            if (args.Length > 1)
            {
                int month = int.Parse(args[0]);
                int year = Convert.ToInt32(args[0]);
                MonthOfYear moy = ConvertToMonth(month);
                int days = DaysInMonth(moy, year);
                Console.WriteLine(days);
            }
        }
        static MonthOfYear ConvertToMonth(int month) {
            return (MonthOfYear)month;
        }
        static int DaysInMonth(MonthOfYear moy, int year) { 
        switch (moy) {
                case MonthOfYear.Jan: return 31;
                case MonthOfYear.Mar: return 31;
                case MonthOfYear.May: return 31;
                case MonthOfYear.Apr: return 31;
                case MonthOfYear.July:return 31;
                case MonthOfYear.Aug:return 31;
                case MonthOfYear.Oct: return 31;
                case MonthOfYear.Dec: return 31;
                case MonthOfYear.Feb: return 0;
                default: return 30;              
            }
                }
        enum MonthOfYear { Jan = 1, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec };
    }

}
